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
    public partial class Frm_Demo_Get_Fiction_Poster : Form
    {
        Thread _th_Main;//下载线程
        int _i_All_Count = 0;//数据库数据条数
        int _i_Success = 0;//下载成功条数
        int _i_Fail = 0;//下载不成功条数
        public Frm_Demo_Get_Fiction_Poster()
        {
            InitializeComponent();
        }

        private void Frm_Demo_Get_Fiction_Poster_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Get_Fiction_Poster_Click(object sender, EventArgs e)
        {
            if (_th_Main != null && _th_Main.IsAlive)
            {
                _th_Main.Abort();
                _th_Main.Join();
                _th_Main = null;
            }
            else
            {
                Tbx_Msg.Clear();
                _th_Main = new Thread(Thread_Get_Fiction_Poster);
                _th_Main.Start();
            }
        }
        /// <summary>
        /// 获取小说封片线程
        /// </summary>
        public void Thread_Get_Fiction_Poster()
        {
            _i_Success = 0;
            _i_Fail = 0;
            List<tb_fiction_info> _ltfi = _1_DAL.Cls_Fiction_Info._o_Get_Fiction_List_By_Query("limit 50000,150000");
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
                PgB_Main.Value = (int)((_i_Success + _i_Fail)*100 / _i_All_Count);
            }));
        }

    }
}
