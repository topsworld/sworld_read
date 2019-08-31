using FictionScrawl._0_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FictionScrawl._5_Demo
{
    public partial class Frm_Demo_Get_Chapter_List : Form
    {
        //Thread _th_Main;//线程
        int _i_All_Count = 0;//数据库数据条数
        int _i_Success = 0;//下载成功条数
        int _i_Fail = 0;//下载不成功条数
        public Frm_Demo_Get_Chapter_List()
        {
            InitializeComponent();
        }

        private void Frm_Demo_Get_Chapter_List_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Get_Fiction_Poster_Click(object sender, EventArgs e)
        {
            _4_ScrawlCore._0_BQG.Cls_Get_Chapter_List _cgcl = new _4_ScrawlCore._0_BQG.Cls_Get_Chapter_List();
            _4_ScrawlCore._0_BQG.Cls_Get_Chapter_Content _cgcc = new _4_ScrawlCore._0_BQG.Cls_Get_Chapter_Content();

            //获取数据库小说信息
            List<tb_fiction_info> _ltfi = _1_DAL.Cls_Fiction_Info._o_Get_Fiction_List_By_Query("limit 0,50000");
            if (_ltfi == null)
                return;

            //获取小说章节列表
            List<tb_chapter_list> _ltcl= _cgcl._b_Get_Chapter_List(_ltfi[0]);
            if (_ltcl.Count == 0)
                return;

            //测试单章小说内容
            string _s_Content= _cgcc.Get_Chapter_Content(_ltcl[0].col_chapter_url);

            //测试整本小说获取
            _cgcc.Event_Delegate += CallBackss;
            _cgcc.Tfi_Main = _ltfi[0];
            _cgcc.Get_All_Chapter_Content(_ltcl);



            //if (_th_Main != null && _th_Main.IsAlive)
            //{
            //    _th_Main.Abort();
            //    _th_Main.Join();
            //    _th_Main = null;
            //}
            //else
            //{
            //    Tbx_Msg.Clear();
            //    _th_Main = new Thread(Thread_Get_Fiction_Poster);
            //    _th_Main.Start();
            //}
        }

        public void CallBackss(int i,List<tb_chapter_list> _ltfi, _4_ScrawlCore._0_BQG.Cls_Get_Chapter_Content _cgcc)
        {
            this.BeginInvoke(new Action(() =>
            {
                PgB_Main.Value = i;
            }));
            if (i == 100)
            {
                if (_cgcc._b_Save_Content("测试.txt", "D://"))
                {

                }
            }
        }

        /// <summary>
        /// 获取小说章节线程
        /// </summary>
        public void Thread_Get_Fiction_Poster()
        {
            _i_Success = 0;
            _i_Fail = 0;
            List<tb_fiction_info> _ltfi = _1_DAL.Cls_Fiction_Info._o_Get_Fiction_List_By_Query("limit 0,50000");
            _i_All_Count = _ltfi.Count();

            Tbx_Msg.BeginInvoke(new Action(() =>
            {
                Lab_All.Text = _i_All_Count.ToString();
            }));

            _4_ScrawlCore._0_BQG.Cls_Fiction_Poster _cfp = new _4_ScrawlCore._0_BQG.Cls_Fiction_Poster();
            foreach (tb_fiction_info _tfi in _ltfi)
            {
                Show_Msg("开始获取小说编号为【" + _tfi.col_fiction_id + "】的小说封皮", 0);
                if (_cfp._b_Get_Fiction_Poster(Environment.CurrentDirectory + "//Poster//" + _tfi.col_fiction_id.ToString() + ".jpg", _tfi.col_url_poster))
                {
                    _i_Success += 1;
                    Show_Msg("获取成功！封皮链接：" + _tfi.col_url_poster, 1);
                }
                else
                {
                    _i_Fail += 1;
                    Show_Msg("获取失败！", 2);
                }
            }
        }

        /// <summary>
        /// 显示消息
        /// </summary>
        /// <param name="_msg"></param>
        public void Show_Msg(string _msg, int _i_type = 0)
        {
            string _s_Type = "";
            switch (_i_type)
            {
                case 0:
                    _s_Type = "INFO";
                    break;
                case 1:
                    _s_Type = " OK ";
                    break;
                case 2:
                    _s_Type = "ERR ";
                    break;
                default:
                    _s_Type = "NULL";
                    break;
            }
            Tbx_Msg.BeginInvoke(new Action(() =>
            {
                Tbx_Msg.AppendText(DateTime.Now.ToString("[yyyy-MM-dd hh:mm:ss]=>") + "(" + _s_Type + ")"
                    + _msg + "\r\n");
                Lab_Success.Text = _i_Success.ToString();
                Lab_Fail.Text = _i_Fail.ToString();
                PgB_Main.Value = (int)((_i_Success + _i_Fail) * 100 / _i_All_Count);
            }));
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
