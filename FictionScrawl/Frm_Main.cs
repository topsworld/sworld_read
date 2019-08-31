using FictionScrawl._0_Model;
using FictionScrawl._3_UIL.MyControl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace FictionScrawl
{
    public partial class Frm_Main : Form
    {
        //实例化操作类
        //小说查找
        _4_ScrawlCore._0_BQG.Cls_Fiction_Search _cfs = new _4_ScrawlCore._0_BQG.Cls_Fiction_Search();

        //参数
        //查找列表
        List<tb_fiction_info> _ltfi_Search;
        //设置配置文件
        tb_json_config _tjc_Config;
        //书架配置文件
        tb_json_bookshelf _tjb_Bookshelf;
        //下载配置文件
        tb_json_download _tjd_Download;

        //操作线程
        //查找小说线程
        Thread _thread_Search;

        public Frm_Main()
        {
            InitializeComponent();
        }


        private void Frm_Main_Load(object sender, EventArgs e)
        {
            //初始化
            Software_Init();
        }

        #region 系统相关

        /// <summary>
        /// 程序初始化
        /// </summary>
        public void Software_Init()
        {
            //初始化时间
            TsLab_Sys_Time.Text = DateTime.Now.ToString("yyyy年MM月dd日 hh:mm:ss");
            //获取配置文件
            _tjc_Config = _2_BLL.Cls_Oprt_Config.Read_Sys_Config();
            _tjb_Bookshelf = _2_BLL.Cls_Oprt_Bookshelf.Read_Bookshelf_Config();
            if (_tjb_Bookshelf == null || _tjb_Bookshelf._ltjfi_Bookshelf == null)//为null，实例化
            {
                _tjb_Bookshelf = new tb_json_bookshelf();
                _tjb_Bookshelf._ltjfi_Bookshelf = new List<tb_json_fiction_info>();
            }
            _tjd_Download = _2_BLL.Cls_Oprt_Download.Read_Download_Config();
            if (_tjd_Download == null || _tjd_Download._ltjfi_Download == null)//|| _tjd_Download._ltjfi_UnDownload == null)//为null，实例化
            {
                _tjd_Download = new tb_json_download();
                _tjd_Download._ltjfi_Download = new List<tb_json_fiction_info>();
                //_tjd_Download._ltjfi_UnDownload = new List<tb_json_fiction_info>();
            }
            //显示书架
            Load_BookShelf();
            //显示下载
            Load_Download();
            //显示配置文件
            if (_tjc_Config != null)
            {
                Nud_Cache_Chapter_Num.Value = _tjc_Config._i_Cache_Chapter;//缓存章节数
                Chbx_Cache_All.Checked = _tjc_Config._b_Cache_All;//是否缓存整本
                Tbx_Bookshelf_Dir.Text = _tjc_Config._s_Bookshelf_Dir;//书架缓存目录
                Nud_Download_Queue_Num.Value = _tjc_Config._i_Download_Queue;//下载队列大小
                Nud_Download_Max_Thread.Value = _tjc_Config._i_Download_Max_Thread;//下载最大线程数
                Tbx_Download_Dir.Text = _tjc_Config._s_Download_Dir;//下载文件保存目录
                Chbx_Auto_Start.Checked = _tjc_Config._b_Autu_Start;//开机自启
            }

            //if (TsBtn_Start_Check_Update.Checked)//开启检查更新线程
            //{
            Check_Update();
            //}

        }

        /// <summary>
        /// 系统时钟显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tmr_Sys_Time_Tick(object sender, EventArgs e)
        {
            TsLab_Sys_Time.Text = DateTime.Now.ToString("yyyy年MM月dd日 hh:mm:ss");
        }

        /// <summary>
        /// 窗体关闭前保存配置文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //保存配置文件
            _2_BLL.Cls_Oprt_Config.Write_Sys_Config(_tjc_Config);
        }

        #endregion

        #region 消息显示
        private void Tmr_Btm_Msg_Tick(object sender, EventArgs e)
        {
            if (TsLab_Btm_Msg.Text != "就绪！")
                TsLab_Btm_Msg.Text = "就绪！";
            Tmr_Btm_Msg.Stop();
        }
        /// <summary>
        /// 显示消息
        /// </summary>
        /// <param name="_msg">消息</param>
        /// <param name="_i">显示类型：
        /// 0：只底部显示
        /// 1：只对话框提示
        /// 2：都提示</param>
        public void Show_Btm_Msg(string _msg,int _i)
        {
            Lv_HomePage.BeginInvoke(new Action(()=> {
                if(_i==0||_i==2)
                TsLab_Btm_Msg.Text = _msg;
                Tmr_Btm_Msg.Stop();
                Tmr_Btm_Msg.Start();
                if (_i == 1||_i==2)
                {
                    MessageBox.Show(_msg,"提示");
                }
            }));
        }
        #endregion

        #region 首页

        #region 查找小说

        public void Thread_Fiction_Search(object _s_kw)
        {
            _ltfi_Search = _cfs._o_Get_Fiction_Info_By_KeyWord(_s_kw.ToString());
            Lv_HomePage.BeginInvoke(new Action(()=> 
            {
                if (_ltfi_Search == null||_ltfi_Search.Count==0)
                {
                    Show_Btm_Msg("无匹配查询结果，请更换关键词后重试！",0);
                    Lv_HomePage.Items.Clear();
                }
                else
                {
                    Show_Btm_Msg("查找成功，相关数据【" + _ltfi_Search.Count + "】条！",0);
                    Show_Search_List(_ltfi_Search);
                }
                Lv_HomePage.Enabled = true;
                Mpgb_Search.Visible = false;
                Lab_Load.Visible = false;
            }));
            
        }

        /// <summary>
        /// 显示查找列表
        /// </summary>
        /// <param name="_ltfi">查找列表</param>
        public void Show_Search_List(List<tb_fiction_info> _ltfi)
        {
            Lv_HomePage.Items.Clear();
            if (_ltfi_Search != null && _ltfi_Search.Count > 0)
            {
                foreach (tb_fiction_info _tfi in _ltfi_Search)
                {
                    ListViewItem _lvi = new ListViewItem(_tfi.col_fiction_type);
                    _lvi.SubItems.Add(_tfi.col_fiction_name);
                    _lvi.SubItems.Add(_tfi.col_fiction_author);
                    _lvi.SubItems.Add(_tfi.col_update_chapter);
                    _lvi.SubItems.Add(_tfi.col_update_time.ToString("yyyy-MM-dd"));
                    _lvi.SubItems.Add(_tfi.col_fiction_stata);
                    _lvi.SubItems.Add(_tfi.col_click_count);
                    _lvi.Tag = _tfi;

                    Lv_HomePage.Items.Add(_lvi);
                }
            }
        }


        #endregion

        #region 按钮等事件


        /// <summary>
        /// 查找小说
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            //标识线程正在执行，需要关闭线程
            if (_thread_Search != null && _thread_Search.IsAlive)
            {
                _thread_Search.Abort();
                _thread_Search.Join();
                _thread_Search = null;
            }

            //disable listview，show progrossbar
            Lv_HomePage.Enabled = false;
            Mpgb_Search.Visible = true;
            Lab_Load.Visible = true;

            _thread_Search = new Thread(Thread_Fiction_Search);
            _thread_Search.IsBackground = true;
            _thread_Search.Start(Tbx_Search.Text);
        }



        /// <summary>
        /// 双击显示详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lv_HomePage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Lv_HomePage.SelectedItems.Count > 0)
            {
                _3_UIL.Frm_Fiction_Detail_Info _ffdi = new _3_UIL.Frm_Fiction_Detail_Info(Lv_HomePage.SelectedItems[0].Tag as tb_fiction_info);
                _ffdi.Owner = this;
                _ffdi.ShowDialog();
            }
        }

        /// <summary>
        /// 小说详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 详情ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lv_HomePage_MouseDoubleClick(null,null);
        }
        /// <summary>
        /// 添加至书架
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 添加至书架ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Lv_HomePage.SelectedItems.Count > 0)
            {
                if (_b_Check_Fiction_IsExit(Lv_HomePage.SelectedItems[0].Tag as tb_fiction_info))
                {
                    Show_Btm_Msg(string.Format("书架中已存在【{0}】，请勿重复操作！", 
                        (Lv_HomePage.SelectedItems[0].Tag as tb_fiction_info).col_fiction_name),2);
                    return;
                }
                tb_fiction_info _tfi = Lv_HomePage.SelectedItems[0].Tag as tb_fiction_info;
                _o_Fiction_Add_BookShelf(_tfi);
                Show_Btm_Msg(string.Format("正在添加【{0}】至书架！", _tfi.col_fiction_name),0);
            }
        }

        

        /// <summary>
        /// 下载小说
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 下载ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Lv_HomePage.SelectedItems.Count > 0)
            {
                if (_b_Check_Download_Fiction_IsExit(Lv_HomePage.SelectedItems[0].Tag as tb_fiction_info))
                {
                    Show_Btm_Msg(string.Format("下载任务中已存在【{0}】，请勿重复操作！",
                        (Lv_HomePage.SelectedItems[0].Tag as tb_fiction_info).col_fiction_name), 2);
                    return;
                }
                tb_fiction_info _tfi = Lv_HomePage.SelectedItems[0].Tag as tb_fiction_info;
                _o_Fiction_Add_Download(_tfi);
                Show_Btm_Msg(string.Format("正在添加【{0}】至下载！", _tfi.col_fiction_name), 0);
            }
        }

        #endregion

        #endregion

        #region 书架

        /// <summary>
        /// 从配置文件加载书架信息
        /// </summary>
        public void Load_BookShelf()
        {
            FlPal_BookShelf.Controls.Clear();
            foreach (tb_json_fiction_info _tjfi in _tjb_Bookshelf._ltjfi_Bookshelf)
            {
                if (_tjfi != null)
                {
                    BookShelf _bs = new BookShelf();
                    _bs.ShowText = _tjfi.col_fiction_name;
                    _bs.Load_Image(_tjfi.col_poster_path);
                    _bs.Tag = _2_BLL.Cls_Oprt_Bookshelf.Read_Bookshelf_Info(_tjfi.col_fiction_path);

                    //添加触发事件
                    _bs.Item_Double_Click += BookShelfItem_DoubleClick;
                    FlPal_BookShelf.Controls.Add(_bs);
                }
            }
        }

        /// <summary>
        /// 检查书架相关书籍是否存在
        /// </summary>
        /// <param name="_tfi">书籍信息</param>
        /// <returns>true：相关书籍已存在； false：不存在</returns>
        public bool _b_Check_Fiction_IsExit(tb_fiction_info _tfi)
        {
            foreach (tb_json_fiction_info _tjfi in _tjb_Bookshelf._ltjfi_Bookshelf)
            {
                if (_tjfi.col_fiction_name == _tfi.col_fiction_name
                    || _tjfi.col_fiction_author == _tfi.col_fiction_author)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 添加书籍信息至书架
        /// </summary>
        /// <param name="_tfdi">书籍详细信息</param>
        public void _o_Fiction_Add_BookShelf(tb_fiction_detail_info _tfdi)
        {
            //新建json存放实体
            tb_json_fiction_info _tjfi_One = new tb_json_fiction_info()
            {
                col_click_count= _tfdi._tfi_Fiction.col_click_count,
                col_fiction_author= _tfdi._tfi_Fiction.col_fiction_author,
                col_fiction_id= _tfdi._tfi_Fiction.col_fiction_id,
                col_fiction_introduction= _tfdi._tfi_Fiction.col_fiction_introduction,
                col_fiction_name= _tfdi._tfi_Fiction.col_fiction_name,
                col_fiction_source = _tfdi._tfi_Fiction.col_fiction_source,
                col_fiction_stata = _tfdi._tfi_Fiction.col_fiction_stata,
                col_fiction_type = _tfdi._tfi_Fiction.col_fiction_type,
                col_remark = _tfdi._tfi_Fiction.col_remark,
                col_update_chapter = _tfdi._tfi_Fiction.col_update_chapter,
                col_update_chapter_url = _tfdi._tfi_Fiction.col_update_chapter_url,
                col_update_time = _tfdi._tfi_Fiction.col_update_time,
                col_url_homepage = _tfdi._tfi_Fiction.col_url_homepage,
                col_url_poster = _tfdi._tfi_Fiction.col_url_poster
            };
            //文件名
            _tjfi_One.col_file_name =DateTime.Now.ToString("yyyyMMddhhmmss-")+_tjfi_One.col_fiction_name
                +"-"+_tjfi_One.col_fiction_author;
            //文件存放路径
            _tfdi._s_File_Path = _tjfi_One.col_fiction_path = Path.Combine(_tjc_Config._s_Bookshelf_Dir
                , _tjfi_One.col_file_name + ".sworld");
            //小说封皮存放路径
            _tfdi._s_Poster=_tjfi_One.col_poster_path = Path.Combine(_tjc_Config._s_Bookshelf_Dir
                ,"Poster"
                , _tjfi_One.col_file_name + ".swimg");
            //保存小说封皮
            _tfdi._img_Poster.Save(_tjfi_One.col_poster_path,System.Drawing.Imaging.ImageFormat.Jpeg);
            _tfdi._img_Poster = null;
            //保存小说文件
            _2_BLL.Cls_Oprt_Bookshelf.Write_Bookshelf_Info(_tfdi,_tjfi_One.col_fiction_path);

            //添加至实体文件
            _tjb_Bookshelf._ltjfi_Bookshelf.Add(_tjfi_One);

            //保存书架配置文件
            _2_BLL.Cls_Oprt_Bookshelf.Write_Bookshelf_Config(_tjb_Bookshelf);

            //添加至书架显示
            BookShelf _bs = new BookShelf();
            _bs.ShowText = _tjfi_One.col_fiction_name;
            _bs.Load_Image(_tjfi_One.col_poster_path);
            _bs.Tag = _tfdi;
            _bs.Item_Double_Click += BookShelfItem_DoubleClick;

            //添加至书架
            FlPal_BookShelf.BeginInvoke(new Action(() =>
            {
                FlPal_BookShelf.Controls.Add(_bs);
            }));
        }

        /// <summary>
        /// 添加书籍信息至书架
        /// </summary>
        /// <param name="_tfdi">书籍详细信息</param>
        public void _o_Fiction_Add_BookShelf(tb_fiction_info _tfi)
        {
            Thread _th_add = new Thread(_thread_Add_BookShelf_Load_Fiction_Info);
            _th_add.IsBackground = true;
            _th_add.Start(_tfi);
        }

        /// <summary>
        /// 加载书籍信息，并添加至书架线程
        /// </summary>
        /// <param name="_o"></param>
        public void _thread_Add_BookShelf_Load_Fiction_Info(object _o)
        {
            _4_ScrawlCore._0_BQG.Cls_Fiction_Search _cfs_Search = new _4_ScrawlCore._0_BQG.Cls_Fiction_Search();
            tb_fiction_detail_info _tfdi_ls = _cfs_Search._o_Get_Fiction_All_Info(_o as tb_fiction_info);
            if (_tfdi_ls != null)
            {
                _o_Fiction_Add_BookShelf(_tfdi_ls);

                Show_Btm_Msg(string.Format("【{0}】已成功添加至书架！", _tfdi_ls._tfi_Fiction.col_fiction_name),0);
            }
            else {
                Show_Btm_Msg(string.Format("【{0}】添加至书架失败！", (_o as tb_fiction_info).col_fiction_name),0);
            }
        }

        /// <summary>
        /// 双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BookShelfItem_DoubleClick(object sender, EventArgs e)
        {
            if (sender == null)
                return;
            _3_UIL.Frm_Fiction_Detail_Info _ffdi = new _3_UIL.Frm_Fiction_Detail_Info(sender as tb_fiction_detail_info);
            _ffdi.Owner = this;
            _ffdi.ShowDialog();
            //保存实体文件
            _2_BLL.Cls_Oprt_Bookshelf.Write_Bookshelf_Info(sender as tb_fiction_detail_info
                ,(sender as tb_fiction_detail_info)._s_File_Path);
        }

        /// <summary>
        /// 获取书架列表选择项
        /// </summary>
        /// <returns></returns>
        public BookShelf _o_Get_Select_Bookshelf()
        {
            foreach (Control _con in FlPal_BookShelf.Controls)
            {
                if ((_con as BookShelf).IsSelect)
                {
                    return (_con as BookShelf);
                }
            }
            return null;
        }

        /// <summary>
        /// 查看小说详情
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 详情ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BookShelf _bs = _o_Get_Select_Bookshelf();
            if (_bs != null)
            {
                BookShelfItem_DoubleClick(_bs.Tag, null);
            }
        }
        /// <summary>
        /// 书架界面 下载小说
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 下载小说ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookShelf _bs = _o_Get_Select_Bookshelf();
            if (_bs != null)
            {
                tb_fiction_detail_info _tfdi = new tb_fiction_detail_info();
                _tfdi=(_bs.Tag as tb_fiction_detail_info);
                //检查下载是否存在
                if (_b_Check_Download_Fiction_IsExit(_tfdi._tfi_Fiction))
                {
                    Show_Btm_Msg(string.Format("下载任务【{0}】已存在，请勿重复操作！",
                        _tfdi._tfi_Fiction.col_fiction_name), 2);
                    return;
                }
                _o_Fiction_Add_Download(_tfdi);
                Show_Btm_Msg(string.Format("【{0}】正在下载中...", _tfdi._tfi_Fiction.col_fiction_name), 0);
            }
        }



        /// <summary>
        /// 删除小说
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 清空缓存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookShelf _bs = _o_Get_Select_Bookshelf();
            if (_bs != null)
            {
                tb_fiction_detail_info _tfdi = _bs.Tag as tb_fiction_detail_info;
                //先删除文件
                File.Delete(_tfdi._s_File_Path);
                File.Delete(_tfdi._s_Poster);
                //删除书架列表文件
                _tjb_Bookshelf._ltjfi_Bookshelf.Remove(
                    _tjb_Bookshelf._ltjfi_Bookshelf.Find(a=>a.col_fiction_path== _tfdi._s_File_Path
                    &&a.col_poster_path==_tfdi._s_Poster));
                if (_2_BLL.Cls_Oprt_Bookshelf.Write_Bookshelf_Config(_tjb_Bookshelf))
                {
                    FlPal_BookShelf.Controls.Remove(_bs);
                    Show_Btm_Msg("小说已从书架移除！",2);
                }
                else
                {
                    Show_Btm_Msg("出现未知错误，移除失败！",2);
                }
            }
        }

        #endregion

        #region 下载

        /// <summary>
        /// 添加书籍信息至下载
        /// </summary>
        /// <param name="_tfdi">书籍详细信息</param>
        public void _o_Fiction_Add_Download(tb_fiction_info _tfi)
        {
            Thread _th_add = new Thread(_thread_Add_Download_Load_Fiction_Info);
            _th_add.IsBackground = true;
            _th_add.Start(_tfi);
        }

        /// <summary>
        /// 加载书籍信息，并添加至下载线程
        /// </summary>
        /// <param name="_o"></param>
        public void _thread_Add_Download_Load_Fiction_Info(object _o)
        {
            _4_ScrawlCore._0_BQG.Cls_Fiction_Search _cfs_Search = new _4_ScrawlCore._0_BQG.Cls_Fiction_Search();
            tb_fiction_detail_info _tfdi_ls = _cfs_Search._o_Get_Fiction_All_Info(_o as tb_fiction_info);
            if (_tfdi_ls != null)
            {
                _o_Fiction_Add_Download(_tfdi_ls);

                Show_Btm_Msg(string.Format("【{0}】已成功添加至下载任务！", _tfdi_ls._tfi_Fiction.col_fiction_name), 0);
            }
            else
            {
                Show_Btm_Msg(string.Format("【{0}】添加至下载任务失败！", (_o as tb_fiction_info).col_fiction_name), 0);
            }
        }

        /// <summary>
        /// 添加下载任务
        /// </summary>
        /// <param name="_tfdi">书籍详细信息</param>
        /// <param name="_ifnew">true：为新建下载任务，不要保存至配置文件  false：从配置文件中恢复的下载任务，不需要保存</param>
        public void _o_Fiction_Add_Download(tb_fiction_detail_info _tfdi,bool _ifnew=true)
        {
            tb_fiction_detail_info _tfdi_read = new tb_fiction_detail_info();
            tb_json_fiction_info _tjfi_One;

            if (_ifnew)
            {
                //新建json存放实体
                _tjfi_One = new tb_json_fiction_info()
                {
                    col_click_count = _tfdi._tfi_Fiction.col_click_count,
                    col_fiction_author = _tfdi._tfi_Fiction.col_fiction_author,
                    col_fiction_id = _tfdi._tfi_Fiction.col_fiction_id,
                    col_fiction_introduction = _tfdi._tfi_Fiction.col_fiction_introduction,
                    col_fiction_name = _tfdi._tfi_Fiction.col_fiction_name,
                    col_fiction_source = _tfdi._tfi_Fiction.col_fiction_source,
                    col_fiction_stata = _tfdi._tfi_Fiction.col_fiction_stata,
                    col_fiction_type = _tfdi._tfi_Fiction.col_fiction_type,
                    col_remark = _tfdi._tfi_Fiction.col_remark,
                    col_update_chapter = _tfdi._tfi_Fiction.col_update_chapter,
                    col_update_chapter_url = _tfdi._tfi_Fiction.col_update_chapter_url,
                    col_update_time = _tfdi._tfi_Fiction.col_update_time,
                    col_url_homepage = _tfdi._tfi_Fiction.col_url_homepage,
                    col_url_poster = _tfdi._tfi_Fiction.col_url_poster
                };
                //文件名
                _tjfi_One.col_file_name = DateTime.Now.ToString("yyyyMMddhhmmss-") + _tjfi_One.col_fiction_name
                    + "-" + _tjfi_One.col_fiction_author;

                //设置小说封皮及文件存放路径
                _tjfi_One.col_fiction_path = Path.Combine(_tjc_Config._s_Download_Dir
                   , _tjfi_One.col_file_name + ".sworld");
                _tjfi_One.col_poster_path = Path.Combine(_tjc_Config._s_Download_Dir
                    , "Poster"
                    , _tjfi_One.col_file_name + ".swimg");

                //保存小说封皮
                _tfdi._img_Poster.Save(_tjfi_One.col_poster_path, System.Drawing.Imaging.ImageFormat.Jpeg);
                _tfdi._img_Poster = null;

                //保存小说文件
                _2_BLL.Cls_Oprt_Download.Write_Download_Info(_tfdi, _tjfi_One.col_fiction_path);

                //重新读取小说文件
                _tfdi_read = _2_BLL.Cls_Oprt_Download.Read_Download_Info(_tjfi_One.col_fiction_path);

                //文件存放路径
                _tfdi_read._s_File_Path = _tjfi_One.col_fiction_path;
                //小说封皮存放路径
                _tfdi_read._s_Poster = _tjfi_One.col_poster_path;

                //添加至实体文件
                _tjd_Download._ltjfi_Download.Add(_tjfi_One);

                //保存书架配置文件
                _2_BLL.Cls_Oprt_Download.Write_Download_Config(_tjd_Download);
                //重新写入最新小说信息
                _2_BLL.Cls_Oprt_Download.Write_Download_Info(_tfdi_read, _tfdi_read._s_File_Path);

            }
            else {
                //查询配置列表，获取配置信息
                _tjfi_One = _tjd_Download._ltjfi_Download.Find(a=>a.col_fiction_name==_tfdi._tfi_Fiction.col_fiction_name
                &&a.col_fiction_author==_tfdi._tfi_Fiction.col_fiction_author);
            }

            //重新读取小说文件
            _tfdi_read = _2_BLL.Cls_Oprt_Download.Read_Download_Info(_tjfi_One.col_fiction_path);
            ListViewItem _lvi = new ListViewItem(_tfdi_read._tfi_Fiction.col_fiction_name);
            _lvi.SubItems.Add(_tfdi_read._tfi_Fiction.col_fiction_author);
            _lvi.SubItems.Add(_tfdi_read._i_Download_Percent.ToString());
            _lvi.SubItems.Add("正在下载");
            _4_ScrawlCore._0_BQG.Cls_Fiction_Download _cfd = new _4_ScrawlCore._0_BQG.Cls_Fiction_Download(_tfdi_read, _lvi);
            _cfd._Download_CallBack += Event_Percent_Change;
            _lvi.Tag = _cfd;

            //添加下载项
            Lve_Download.BeginInvoke(new Action(()=>
            {
                Lve_Download.Items.Add(_lvi);
            }));

            //开始下载
            _cfd.Start();
        }


        /// <summary>
        /// 检查下载相关书籍是否存在
        /// </summary>
        /// <param name="_tfi">书籍信息</param>
        /// <returns>true：相关书籍已存在； false：不存在</returns>
        public bool _b_Check_Download_Fiction_IsExit(tb_fiction_info _tfi)
        {
            //正在下载
            foreach (tb_json_fiction_info _tjfi in _tjd_Download._ltjfi_Download)
            {
                if (_tjfi.col_fiction_name == _tfi.col_fiction_name
                    || _tjfi.col_fiction_author == _tfi.col_fiction_author)
                    return true;
            }
            ////下载完成
            //foreach (tb_json_fiction_info _tjfi in _tjd_Download._ltjfi_UnDownload)
            //{
            //    if (_tjfi.col_fiction_name == _tfi.col_fiction_name
            //        || _tjfi.col_fiction_author == _tfi.col_fiction_author)
            //        return true;
            //}
            return false;
        }

        /// <summary>
        /// 获取总下载进度
        /// </summary>
        /// <returns></returns>
        public void _o_Get_Download_All_Percent()
        {
            int _all_percent = 0;
            foreach (ListViewItem _lvi in Lve_Download.Items)
            {
                try
                {
                    _all_percent += int.Parse(_lvi.SubItems[2].Text);
                }
                catch { }
            }
            if(Lve_Download.Items.Count>0)
                _all_percent = _all_percent / Lve_Download.Items.Count;
            Mpgb_All_Percent.Value = _all_percent;
            Lab_All_Percent.Text = _all_percent + "%";
        }

        /// <summary>
        /// 下载进度事件
        /// </summary>
        /// <param name="_tfdi">下载信息实体</param>
        /// <param name="_lvi">下载项</param>
        /// <param name="_stop">false：继续下载；true：暂停下载</param>
        public void Event_Percent_Change(tb_fiction_detail_info _tfdi, ListViewItem _lvi)
        {
            Lve_Download.BeginInvoke(new Action(() =>
            {
                if (_tfdi != null)//正常事件
                {
                    _lvi.SubItems[2].Text = _tfdi._i_Download_Percent.ToString();//显示进度
                    //刷新总下载进度
                    _o_Get_Download_All_Percent();
                    if (_tfdi._i_Download_Percent == 100)//下载完成
                    {
                        //下载完成需要写入
                        //获取列表信息
                        //下载完成绑定Tag  为 tb_json_fiction_info 类型
                        tb_json_fiction_info _tjfi = _tjd_Download._ltjfi_Download.Find(a => a.col_fiction_name == _tfdi._tfi_Fiction.col_fiction_name
                         && a.col_fiction_author == _tfdi._tfi_Fiction.col_fiction_author);

                        if (_tjfi != null)
                        {
                            //需要更新配置文件和小说物理文件【下载完成】和【下载进度】标识信息
                            _tjfi.B_IsDownload = _tfdi.B_IsDownload = true;
                            _tjfi._i_Download_Percent = _tfdi._i_Download_Percent;
                            _2_BLL.Cls_Oprt_Download.Write_Download_Config(_tjd_Download);//写入配置信息
                            _2_BLL.Cls_Oprt_Download.Write_Download_Info(_tfdi, _tfdi._s_File_Path);//保存小说信息
                            ListViewItem _lvi_Download = _lvi.Clone() as ListViewItem;
                            Lve_Download.Items.Remove(_lvi);//移除正在下载列表
                            
                            _lvi_Download.Tag = _tjfi;
                            _lvi_Download.SubItems[3].Text = "下载完成";
                            Lve_Downloaded.Items.Add(_lvi_Download);//添加至下载完成列表
                            //更新下载完成提示
                            Show_Btm_Msg("小说【"+_tjfi.col_fiction_name+"】下载完成！",0);
                            Lab_Downloaded_Count_Tip.Text = "共下载"+Lve_Downloaded.Items.Count+"本小说";
                        }
                    }
                }
                else//为null  表示任务取消
                {
                    Lve_Download.Items.Remove(_lvi);
                }
            }));
        }

        /// <summary>
        /// 从配置文件加载书架信息
        /// </summary>
        public void Load_Download()
        {
            Lve_Download.Items.Clear();
            Lve_Downloaded.Items.Clear();

            //正在下载
            foreach (tb_json_fiction_info _tjfi in _tjd_Download._ltjfi_Download)
            {
                if (_tjfi != null)
                {
                    
                    //tb_fiction_detail_info _tfdi= _2_BLL.Cls_Oprt_Download.Read_Download_Info(_tjfi.col_fiction_path);
                    
                    //下载完成绑定Tag 为 tb_json_fiction_info 类型
                    //正在下载绑定Tag 为 Cls_Fiction_Download 类 
                    if (_tjfi.B_IsDownload)
                    {
                        //下载完成
                        ListViewItem _lvi = new ListViewItem(_tjfi.col_fiction_name);
                        _lvi.SubItems.Add(_tjfi.col_fiction_author);
                        _lvi.SubItems.Add("100");
                        _lvi.SubItems.Add("下载完成");
                        _lvi.Tag = _tjfi;
                        Lve_Downloaded.Items.Add(_lvi);
                    }
                    else
                    {
                        //继续下载
                        //获取小说下载实体i
                        tb_fiction_detail_info _tfdi_ing= _2_BLL.Cls_Oprt_Download.Read_Download_Info(_tjfi.col_fiction_path);
                        if (_tfdi_ing != null)
                        {
                            _o_Fiction_Add_Download(_tfdi_ing,false);
                        }
                    }
                }
            }
            //刷新总下载进度
            _o_Get_Download_All_Percent();
            //显示下载完成小说数量
            Lab_Downloaded_Count_Tip.Text = "共下载" + Lve_Downloaded.Items.Count + "本小说";
            //下载完成

        }

        /// <summary>
        /// 继续单个任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 开始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断是否有选择项
            if (Lve_Download.SelectedItems.Count == 0)
                return;
            _4_ScrawlCore._0_BQG.Cls_Fiction_Download _cfd = Lve_Download.SelectedItems[0].Tag as _4_ScrawlCore._0_BQG.Cls_Fiction_Download;
            _cfd.Continue();
            _cfd.Lvi_Download.SubItems[3].Text = "准备下载";
        }

        /// <summary>
        /// 停止单个任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 停止ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断是否有选择项
            if (Lve_Download.SelectedItems.Count == 0)
                return;
            _4_ScrawlCore._0_BQG.Cls_Fiction_Download _cfd = Lve_Download.SelectedItems[0].Tag as _4_ScrawlCore._0_BQG.Cls_Fiction_Download;
            _cfd.Stop();
            _cfd.Lvi_Download.SubItems[3].Text = "正在暂停";
            //暂停下载需要重新更新物理文件
            _2_BLL.Cls_Oprt_Download.Write_Download_Config(_tjd_Download);
            _2_BLL.Cls_Oprt_Download.Write_Download_Info(_cfd.Tfdi_Main,_cfd.Tfdi_Main._s_File_Path);
        }
        /// <summary>
        /// 删除单个任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //判断是否有选择项
            if (Lve_Download.SelectedItems.Count == 0)
                return;
            _4_ScrawlCore._0_BQG.Cls_Fiction_Download _cfd = Lve_Download.SelectedItems[0].Tag as _4_ScrawlCore._0_BQG.Cls_Fiction_Download;
            if (_cfd == null) return;
            //获取原来任务状态
            bool _stop = _cfd.B_Stop;
            //先暂停任务
            _cfd.Stop();
            if (MessageBox.Show("是否取消任务：【" + _cfd.Tfdi_Main._tfi_Fiction.col_fiction_name + "】？\r\n取消任务会放弃已下载内容。"
                , "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //删除选中下载任务
                _cfd.Cancel();
                //删除配置文件信息
                tb_json_fiction_info _tjfi = _tjd_Download._ltjfi_Download.Find(a => a.col_fiction_name == _cfd.Tfdi_Main._tfi_Fiction.col_fiction_name
                         && a.col_fiction_author == _cfd.Tfdi_Main._tfi_Fiction.col_fiction_author);
                if(File.Exists(_tjfi.col_fiction_path))//删除小说
                    File.Delete(_tjfi.col_fiction_path);
                if (File.Exists(_tjfi.col_poster_path))//删除封皮
                    File.Delete(_tjfi.col_poster_path);
                _tjd_Download._ltjfi_Download.Remove(_tjfi);//移除配置文件对应项
                _2_BLL.Cls_Oprt_Download.Write_Download_Config(_tjd_Download);//更新配置文件
            }
            else
            {
                //状态为正在下载时，取消删除单个任务，恢复下载
                if(!_stop)
                    _cfd.Continue();
            }
        }
        /// <summary>
        /// 全部开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Download_All_Start_Click(object sender, EventArgs e)
        {
            if (Lve_Download.Items.Count == 0)
                return;
            foreach (ListViewItem _lvi in Lve_Download.Items)
            {
                if (_lvi.SubItems[3].Text == "正在暂停"
                || _lvi.SubItems[3].Text == "暂停下载")
                {
                    //可继续下载
                    _4_ScrawlCore._0_BQG.Cls_Fiction_Download _cfd = _lvi.Tag as _4_ScrawlCore._0_BQG.Cls_Fiction_Download;
                    _cfd.Continue();
                    _lvi.SubItems[3].Text = "准备下载";
                }
            }
            Show_Btm_Msg("开始全部下载任务...", 0);
        }
        /// <summary>
        /// 全部暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Download_All_Stop_Click(object sender, EventArgs e)
        {
            if (Lve_Download.Items.Count == 0)
                return;
            foreach (ListViewItem _lvi in Lve_Download.Items)
            {
                if (_lvi.SubItems[3].Text == "正在下载"
                || _lvi.SubItems[3].Text == "准备下载")
                {
                    //可停止下载
                    _4_ScrawlCore._0_BQG.Cls_Fiction_Download _cfd = _lvi.Tag as _4_ScrawlCore._0_BQG.Cls_Fiction_Download;
                    _cfd.Stop();
                    _lvi.SubItems[3].Text = "正在暂停";
                    //暂停下载需要重新更新物理文件
                    _2_BLL.Cls_Oprt_Download.Write_Download_Config(_tjd_Download);
                    _2_BLL.Cls_Oprt_Download.Write_Download_Info(_cfd.Tfdi_Main, _cfd.Tfdi_Main._s_File_Path);
                }
            }
            Show_Btm_Msg("暂停全部下载任务...", 0);
        }
        /// <summary>
        /// 全部取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Download_ALL_Cancel_Click(object sender, EventArgs e)
        {
            if (Lve_Download.Items.Count == 0)
                return;
            List<(_4_ScrawlCore._0_BQG.Cls_Fiction_Download,bool)> _lcfg = new List<(_4_ScrawlCore._0_BQG.Cls_Fiction_Download, bool)>();
            foreach (ListViewItem _lvi in Lve_Download.Items)
            {
                _4_ScrawlCore._0_BQG.Cls_Fiction_Download _cfg = _lvi.Tag as _4_ScrawlCore._0_BQG.Cls_Fiction_Download;
                bool _stop = _cfg.B_Stop;
                _cfg.Stop();
                _lcfg.Add((_cfg, _stop));
            }
            if (MessageBox.Show("是否取消全部任务？"
                , "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //删除全部正在下载任务
                foreach (var _v in _lcfg)
                {
                    _v.Item1.Cancel();

                }
                //停止全部任务
                _lcfg.ForEach(a=>a.Item1.Cancel());

                //删除文件
                //移除对应项
                foreach (tb_json_fiction_info _tjfi_ls in _tjd_Download._ltjfi_Download.FindAll(a => a.B_IsDownload == false))
                {
                    if (File.Exists(_tjfi_ls.col_fiction_path))//删除小说
                        File.Delete(_tjfi_ls.col_fiction_path);
                    if (File.Exists(_tjfi_ls.col_poster_path))//删除封皮
                        File.Delete(_tjfi_ls.col_poster_path);
                    _tjd_Download._ltjfi_Download.Remove(_tjfi_ls);
                }
                _2_BLL.Cls_Oprt_Download.Write_Download_Config(_tjd_Download);//更新配置文件
            }
            else
            {
                //状态为正在下载时，取消删除单个任务，恢复下载
                foreach ((_4_ScrawlCore._0_BQG.Cls_Fiction_Download, bool) _var in _lcfg)
                {
                    if (!_var.Item2)
                        _var.Item1.Continue();
                }
            }

        }

        /// <summary>
        /// 正在下载双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lve_Download_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Lve_Download.SelectedItems.Count == 0)
                return;
            if (Lve_Download.SelectedItems[0].SubItems[3].Text == "正在暂停"
                || Lve_Download.SelectedItems[0].SubItems[3].Text == "暂停下载")
            {
                //可继续下载
                开始ToolStripMenuItem_Click(null, null);
            }
            else if (Lve_Download.SelectedItems[0].SubItems[3].Text == "正在下载"
                || Lve_Download.SelectedItems[0].SubItems[3].Text == "准备下载")
            {
                //可停止下载
                停止ToolStripMenuItem_Click(null,null);
            }

        }

        /// <summary>
        /// 正在下载右键打开菜单栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cms_Download_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Lve_Download.SelectedItems.Count == 0)
            {
                e.Cancel = true;
                return;
            }
            
            if (Lve_Download.SelectedItems[0].SubItems[3].Text == "正在暂停"
                || Lve_Download.SelectedItems[0].SubItems[3].Text == "暂停下载")
            {
                //可继续下载
                Cms_Download.Items[0].Enabled = true;
                Cms_Download.Items[1].Enabled = false;
            }
            else if (Lve_Download.SelectedItems[0].SubItems[3].Text == "正在下载"
                || Lve_Download.SelectedItems[0].SubItems[3].Text == "准备下载")
            {
                //可停止下载
                Cms_Download.Items[0].Enabled = false;
                Cms_Download.Items[1].Enabled = true;
            }
        }

        /// <summary>
        /// 打开已下载小说
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 打开小说ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Lve_Downloaded.SelectedItems.Count == 0)
                return;

            tb_fiction_detail_info _tfdi = 
                _2_BLL.Cls_Oprt_Download.Read_Download_Info((Lve_Downloaded.SelectedItems[0].Tag as tb_json_fiction_info).col_fiction_path );
            _3_UIL.Frm_Fiction_Detail_Info _ffdi = new _3_UIL.Frm_Fiction_Detail_Info(_tfdi, 2);
            _ffdi.Owner = this;
            _ffdi.ShowDialog();
        }
        /// <summary>
        /// 导出已下载小说
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 导出TxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Lve_Downloaded.SelectedItems.Count == 0)
                return;
            tb_fiction_detail_info _tfdi =
                _2_BLL.Cls_Oprt_Download.Read_Download_Info((Lve_Downloaded.SelectedItems[0].Tag as tb_json_fiction_info).col_fiction_path);
            //默认保存到桌面
            Sfd_Output_To_Txt.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Sfd_Output_To_Txt.FileName = _tfdi._tfi_Fiction.col_fiction_name;
            if (Sfd_Output_To_Txt.ShowDialog() == DialogResult.OK)
            {
                if (_2_BLL.Cls_Oprt_Download.Output_Fiction_To_Txt(_tfdi, Sfd_Output_To_Txt.FileName))
                    Show_Btm_Msg(string.Format("【{0}】导出成功！\r\n导出路径：{1}"
                        , _tfdi._tfi_Fiction.col_fiction_name, Sfd_Output_To_Txt.FileName), 2);
                else
                    Show_Btm_Msg(string.Format("【{0}】导出失败！"
                        , _tfdi._tfi_Fiction.col_fiction_name), 2);
            }
        }
        /// <summary>
        /// 删除已下载小说
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除小说ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Lve_Downloaded.SelectedItems.Count == 0)
                return;
            tb_json_fiction_info _tjfi = Lve_Downloaded.SelectedItems[0].Tag as tb_json_fiction_info;
            if (MessageBox.Show("是否删除【"+_tjfi.col_fiction_name+"】？","提示",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            //删除小说
            if (File.Exists(_tjfi.col_fiction_path))
                File.Delete(_tjfi.col_fiction_path);
            //删除小说封皮
            if (File.Exists(_tjfi.col_poster_path))
                File.Delete(_tjfi.col_poster_path);
            //移除配置文件相关信息
            _tjd_Download._ltjfi_Download.Remove(_tjfi);
            //保存配置信息
            _2_BLL.Cls_Oprt_Download.Write_Download_Config(_tjd_Download);
            //移除显示项
            Lve_Downloaded.Items.Remove(Lve_Downloaded.SelectedItems[0]);
        }

        /// <summary>
        /// 清除所有下载记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Download_Clear_Downloaded_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否清除所有下载记录？", "提示") == DialogResult.No)
                return;
            //删除文件
            //移除对应项
            foreach (tb_json_fiction_info _tjfi_ls in _tjd_Download._ltjfi_Download.FindAll(a => a.B_IsDownload == true))
            {
                if (File.Exists(_tjfi_ls.col_fiction_path))//删除小说
                    File.Delete(_tjfi_ls.col_fiction_path);
                if (File.Exists(_tjfi_ls.col_poster_path))//删除封皮
                    File.Delete(_tjfi_ls.col_poster_path);
                _tjd_Download._ltjfi_Download.Remove(_tjfi_ls);
            }
            Lve_Downloaded.Items.Clear();
            _2_BLL.Cls_Oprt_Download.Write_Download_Config(_tjd_Download);//更新配置文件
        }

        /// <summary>
        /// 双击下载完成列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lve_Downloaded_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            打开小说ToolStripMenuItem_Click(null,null);
        }
        /// <summary>
        /// 右键下载完成菜单项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cms_Downloaded_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Lve_Downloaded.SelectedItems.Count == 0)
            {
                e.Cancel = true;
                return;
            }
        }

        #endregion

        #region 系统设置




        #region 按钮等事件
        /// <summary>
        /// 清除缓存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Cache_Clear_Click(object sender, EventArgs e)
        {
            Show_Btm_Msg("缓存清除成功！",0);
        }
        /// <summary>
        /// 缓存目录选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Cache_Dir_Select_Click(object sender, EventArgs e)
        {
            Show_Btm_Msg("暂不支持更改！", 0);
        }
        /// <summary>
        /// 下载目录选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Download_Dir_Select_Click(object sender, EventArgs e)
        {
            Show_Btm_Msg("暂不支持更改！", 0);
        }

        /// <summary>
        /// 保存设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Save_Config_Click(object sender, EventArgs e)
        {
            //阅读缓存章节数
            _tjc_Config._i_Cache_Chapter = (int)Nud_Cache_Chapter_Num.Value;
            //缓存整本
            _tjc_Config._b_Cache_All = Chbx_Cache_All.Checked;
            //书架缓存目录
            _tjc_Config._s_Bookshelf_Dir = Tbx_Bookshelf_Dir.Text;
            //小说下载队列大小
            _tjc_Config._i_Download_Queue = (int)Nud_Download_Queue_Num.Value;
            //下载最大线程数
            _tjc_Config._i_Download_Max_Thread = (int)Nud_Download_Max_Thread.Value;
            //小说下载目录
            _tjc_Config._s_Download_Dir = Tbx_Download_Dir.Text;
            //是否开机自启
            _tjc_Config._b_Autu_Start = Chbx_Auto_Start.Checked;
            //保存设置
            if (_2_BLL.Cls_Oprt_Config.Write_Sys_Config(_tjc_Config))
            {
                MessageBox.Show("设置保存成功！", "提示");
            }
            else
            {
                MessageBox.Show("设置保存失败！", "提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 个人网站
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LLab_HomePage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetDataObject(LLab_HomePage.Text);
            Show_Btm_Msg("链接已复制，请打开浏览器复制访问。",0);
        }
        /// <summary>
        /// 博客地址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LLab_Blog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetDataObject(LLab_Blog.Text);
            Show_Btm_Msg("链接已复制，请打开浏览器复制访问。", 0);
        }
        /// <summary>
        /// QQ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LLab_QQ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetDataObject(LLab_QQ.Text);
            Show_Btm_Msg("QQ号码已复制。", 0);
        }
        #endregion

        #endregion


        #region 软件更新
        /// <summary>
        /// 程序更新线程
        /// </summary>
        Thread Th_Update=null;
        /// <summary>
        /// 检查更新
        /// </summary>
        private void Check_Update()
        {
            if (Th_Update == null)
            {
                Th_Update = new Thread(Th_Check_Update);
                Th_Update.Start();
            }
        }

        /// <summary>
        /// 程序更新线程函数
        /// </summary>
        private void Th_Check_Update()
        {
            List<tb_version_info> _lvi = _2_BLL.Cls_Oprt_Update.Get_Version_List();
            if (_lvi != null && _lvi[0].Version != Properties.Resources.Version)//判断是否为最新版本
            {
                Show_Btm_Msg("检查到新版本！",0);
                this.BeginInvoke(new Action(() =>
                {
                    if (MessageBox.Show(string.Format("软件当前版本为【{0}】，检测到最新版本为【{1}】，是否更新？\r\n不在提示勾掉【设置>帮助>更新>启动时检查更新】即可！"
                    , Properties.Resources.Version, _lvi[0].Version), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        if (_2_BLL.Cls_Oprt_Update.ExtractResEXE() == 0)//成功抽取更新文件
                        {
                            System.Diagnostics.Process.Start("Update_Soft.exe", "SWorld阅读 " + _lvi[0].Version);//运行更新程序
                            Application.Exit();//退出本软件
                        }
                    }
                    Th_Update.Abort();
                    Th_Update.Join();
                    Th_Update = null;
                }));
            }
            else
            {
                Show_Btm_Msg("软件已是最新版本！",0);
            }
        }

        #endregion

    }
}
