using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Update_Soft.Model;

namespace Update_Soft
{
    /// <summary>
    /// 说明：
    /// 系统文件下载采用FTP形式。
    /// 
    /// 匿名身份信息：
    /// 用户名：update
    /// 密码：Xp19960329.
    /// 权限：读取
    /// 
    /// 管理身份信息：
    /// 用户名：sworld
    /// 密码：Xp199603290031.
    /// 权限：读取、写入
    /// </summary>
    public partial class Update : Form
    {
        //服务器信息
        static string Server_URL = "ftp://update.sworld.ltd/";

        Thread th_Update;//软件后台更新线程
        List<File_Info> _lvi_Soft=new List<File_Info>();//待更新文件列表
        double d_Soft_Size = 0;     //待下载数据总大小
        FileStream outputStream;//写入文件流
        string Soft_Name = "";//软件名称
        string Soft_Version = "";//软件版本号
        public Update(string name ,string version)
        {
            InitializeComponent();
            Soft_Name = name;
            Soft_Version = version;
            Lab_Version_Info.Text =string.Format("更新软件信息：{0} {1}",Soft_Name,Soft_Version);
        }

        private void Update_Load(object sender, EventArgs e)
        {
            Start_Update();
        }

        /// <summary>
        /// 显示更新进度
        /// </summary>
        /// <param name="val"></param>
        private void Show_Process(int val=0)
        {
            this.BeginInvoke(new Action(()=>{
                if (Pgb_Process.Value != val)//进度改变才刷新
                {
                    Pgb_Process.Value = val;
                    Lab_Process.Text = string.Format("软件更新中({0}%)...", val);
                }
            })); 
        }

        /// <summary>
        /// 显示提示消息
        /// </summary>
        /// <param name="msg"></param>
        private void Show_Msg(string msg)
        {
            this.BeginInvoke(new Action(() => {
                Lab_Msg.Text = msg;
            }));
        }


        /// <summary>
        /// 更新软件
        /// </summary>
        private void Start_Update()
        {
            th_Update = new Thread(Th_Update);
            th_Update.IsBackground = true;
            th_Update.Start();
        }

        /// <summary>
        /// 软件更新线程
        /// </summary>
        private void Th_Update()
        {
            _lvi_Soft = Get_Version_List();//获取软件列表
            if (_lvi_Soft != null
                && Down_New_Version(_lvi_Soft) == 0
                && Replace_Soft() == 0)
            {
                Thread.Sleep(1000);
                Show_Msg("软件更新成功！\r\n【1秒后关闭更新程序】");
                Thread.Sleep(1000);
                this.BeginInvoke(new Action(() =>
                {
                    DeleteItself();
                }));

            }
            else//没有获取到软件列表信息
            {
                Show_Process(100);
                Show_Msg("软件更新失败！");
                this.BeginInvoke(new Action(() =>
                {
                    MessageBox.Show("软件更新失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }));
            }
        }

        #region 软件更新函数
        /// <summary>
        /// 获取文件列表信息
        /// </summary>
        /// <returns></returns>
        public List<File_Info> Get_Version_List()
        {
            try
            {
                Show_Process(0);
                Show_Msg("进度1/3：更新软件准备中...");
                // 创建一个FTP请求，建立连接
                FtpWebRequest reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(Server_URL+ Soft_Name+"/"+Soft_Version));
                // 指定ftp服务器的登录用户名和密码
                reqFTP.Credentials = new NetworkCredential();
                reqFTP.UseBinary = true;    // 使用二进制传输方式
                reqFTP.KeepAlive = false;   // 命令执行之后关闭连接
                reqFTP.EnableSsl = false;   // 不使用SSL连接
                reqFTP.UsePassive = true;   // 使用被动模式

                // 设置要发送到FTP服务器的命令为：获取服务器上的文件列表
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

                // 获取FTP服务器的相应数据流
                Stream stream = reqFTP.GetResponse().GetResponseStream();

                // 根据FTP服务器的相应数据流实例化一个 读入流
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                String fileName = reader.ReadLine(); // 读取ftp服务器上的一行数据
                List<File_Info> _lfi = new List<File_Info>();
                while (fileName != null)
                {
                    //跳过目录
                    if (fileName.Contains("<DIR>"))
                    {
                        fileName = reader.ReadLine();
                        continue;
                    }
                    fileName = System.Text.RegularExpressions.Regex.Replace(fileName, @"\s+", "*");
                    string[] _s_ls = fileName.Split('*');
                    if (_s_ls.Length == 4)
                    {
                        File_Info _fi = new File_Info()
                        {
                            Date = _s_ls[0],//获取日期
                            Time = _s_ls[1],//获取时间
                            Size = double.Parse(_s_ls[2]),
                            Name = _s_ls[3],//获取文件名
                        };
                        _lfi.Add(_fi);
                    }
                    fileName = reader.ReadLine();
                }
                d_Soft_Size = _lfi.Sum(a => a.Size);//获取待下载数据大小
                return _lfi;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 下载最新版本
        /// </summary>
        /// <returns></returns>
        public int Down_New_Version(List<File_Info> _lfi)
        {
            try
            {
                double d_ls_Size = 0;
                Show_Process(20);
                Show_Msg("进度2/3：正在下载软件最新版本...");
                //相关目录存在删除重新创建
                if (Directory.Exists("Update"))
                {
                    Directory.Delete("Update", true);
                }
                Directory.CreateDirectory("Update");

                foreach(File_Info _fi in _lfi)
                {
                    //跳过配置文件，json后缀为配置文件
                    if (_fi.Name.Contains(".json")) continue;

                    // 下载单个文件
                    FtpWebRequest reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(Server_URL + Soft_Name + "/" + Soft_Version+"/"+ _fi.Name));
                    Show_Msg(string.Format("进度2/3：下载文件【{0}】...",_fi.Name));
                    reqFTP.Credentials = new NetworkCredential();
                    reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;

                    Stream ftpStream = reqFTP.GetResponse().GetResponseStream();

                    byte[] buffer = new byte[1024];

                    // 实例化本地文件的输入流，用于接收从FTP服务器下载的数据
                    outputStream = new FileStream("Update//" + _fi.Name, FileMode.OpenOrCreate);

                    int readCount = ftpStream.Read(buffer, 0, 1024);

                    while (readCount > 0)
                    {
                        d_ls_Size += readCount;
                        Show_Process(20 + (int)(d_ls_Size * 60 / d_Soft_Size));//显示下载进度
                        outputStream.Write(buffer, 0, readCount);
                        readCount = ftpStream.Read(buffer, 0, 1024);
                    }

                    ftpStream.Close();
                    outputStream.Close();
                }
                return 0;
            }
            catch
            {
                return -1;
            }
        }

        /// <summary>
        /// 覆盖原有软件
        /// </summary>
        /// <returns></returns>
        private int Replace_Soft()
        {
            try
            {
                Show_Process(85);
                Show_Msg("进度3/3：正在替换文件...");
                Thread.Sleep(200);
                //删除原有文件
                string[] files = Directory.GetFiles(Application.StartupPath);
                foreach (string file in files)
                {
                    if (Application.ExecutablePath != file)
                    {
                        try
                        {
                            File.Delete(file);
                        }
                        catch { }
                    }
                }
                Show_Process(90);
                //覆盖原有文件
                files = Directory.GetFiles("Update");
                foreach (string file in files)
                {
                    Show_Process(90+(10/files.Length));
                    File.Copy(file, Path.GetFileName(file), true);
                }
                Show_Process(100);
                Show_Msg("软件更新成功！\r\n【2秒后关闭更新程序】");
                return 0;
            }
            catch
            {
                return -1;
            }
        }
        #endregion

        #region 窗体移动代码

        //该函数从当前线程中窗口释放鼠标捕获
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //发送消息移动窗体
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;    //向窗口发送消息
        public const int SC_MOVE = 0xF010;          //向窗口发送移动的消息
        public const int HTCAPTION = 0x0002;

        private void Update_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        #endregion

        #region LOGO旋转效果
        int i_Rot_Ang = 0;
        /// <summary>
        /// 定时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tmr_Img_Tick(object sender, EventArgs e)
        {
            i_Rot_Ang += 2;
            Pbx_Logo.Image = RotateImage( -i_Rot_Ang);
            if (i_Rot_Ang == 720)
                i_Rot_Ang = 0;
        }

        public Image RotateImage(float rotationAngle)
        {
            Bitmap bmp_Logo = new Bitmap(128, 128);
            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp_Logo);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform(64,64);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-64, -64);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(Properties.Resources.swlogo, new Point(0, 0));

            gfx.Dispose();
            //return the image
            return bmp_Logo;
        }

        #endregion

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [Obsolete]
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            if(th_Update.IsAlive)
                th_Update.Suspend();
            Tmr_Img.Stop();
            if (MessageBox.Show("正在更新软件，是否停止更新并退出？", "提示"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (th_Update.IsAlive)
                {
                    th_Update.Resume();
                    th_Update.Abort();
                    th_Update.Join();
                }
                DeleteItself();
            }
            else
            {
                if (th_Update.IsAlive)
                    th_Update.Resume();
                Tmr_Img.Start();
            }
        }



        /// <summary>
        /// 删除程序自身
        /// </summary>
        private static void DeleteItself()
        {
            string vBatFile = Path.GetDirectoryName(Application.ExecutablePath) + "\\DeleteItself.bat";
            using (StreamWriter vStreamWriter = new StreamWriter(vBatFile, false, Encoding.Default))
            {
                vStreamWriter.Write(string.Format(
                    ":del\r\n" +
                    " del \"{0}\"\r\n" +
                    "if exist \"{0}\" goto del\r\n" +
                    " rd /s /q \"{1}\\Update\\\"\r\n" +
                    "if exist \"{1}\\Update\" goto del\r\n" +
                    "del %0\r\n", Application.ExecutablePath, Application.StartupPath));
            }

            //************ 执行批处理
            WinExec(vBatFile, 0);
            //************ 结束退出
            Application.Exit();
        }


        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        public static extern uint WinExec(string lpCmdLine, uint uCmdShow);

    }
}
