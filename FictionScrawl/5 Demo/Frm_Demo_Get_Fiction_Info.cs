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
    public partial class Frm_Demo_Get_Fiction_Info : Form
    {
        Thread TH_Main;
        int _i_Success = 0;
        int _i_Fail = 0;
        //爬取范围
        int _i_Min_Val = 0;
        int _i_Max_Val = 0;

        public Frm_Demo_Get_Fiction_Info()
        {
            InitializeComponent();
        }

        private void Frm_Demo_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //_4_ScrawlCore._0_BQG.Cls_HomePage _sc = new _4_ScrawlCore._0_BQG.Cls_HomePage("https://www.qu.la/book/3/");
            //tb_fiction_info _tfi= _sc._o_Get_Fiction_Info();
            //_1_DAL.Cls_Fiction_Info._b_Insert_Fiction_Info(_tfi);
            if (Nud_Max_Val.Value <= Nud_Min_Val.Value)
            {
                MessageBox.Show("爬取范围有误！","提示");
                return;
            }

            if (TH_Main != null && TH_Main.IsAlive)
            {
                TH_Main.Abort();
                TH_Main.Join();
                TH_Main = null;
            }
            else
            {
                Tbx_Msg.Clear();
                TH_Main = new Thread(TH_Get_Fiction_Info);
                TH_Main.Start();
            }
        }

        public void TH_Get_Fiction_Info()
        {
            _4_ScrawlCore._0_BQG.Cls_HomePage _sc = new _4_ScrawlCore._0_BQG.Cls_HomePage();
            string _s_URL = "";
            _i_Success = 0;
            _i_Fail = 0;

            //获取爬取范围
            this.BeginInvoke(new Action(()=> {
                _i_Min_Val = (int)Nud_Min_Val.Value;
                _i_Max_Val = (int)Nud_Max_Val.Value;
            }));

            for (int i = _i_Min_Val; i < _i_Max_Val; i++)
            {
                _s_URL = string.Format("https://www.qu.la/book/{0}/", i);
                Show_Msg("开始爬取编号为【"+i+"】的小说信息，地址："+ _s_URL,0);
                tb_fiction_info _tfi = _sc._o_Get_Fiction_Info(_s_URL);
                if (_tfi != null)
                {
                    Show_Msg("爬取成功，小说名：《"+_tfi.col_fiction_name+"》，准备写入数据库；",1);
                    if (_1_DAL.Cls_Fiction_Info._b_Insert_Fiction_Info(_tfi))
                    {
                        Show_Msg("写入数据库成功！",1);
                        _i_Success += 1;
                    }
                    else
                    {
                        Show_Msg("写入数据库失败！",2);
                        _i_Fail += 1;
                    }
                }
                else
                {
                    Show_Msg("爬取失败！",2);
                    _i_Fail += 1;
                }
                
            }

            Show_Msg(string.Format("爬取完成！成功【{0}】条，失败【{1}】条。" ,_i_Success, _i_Fail),0);
        }

        /// <summary>
        /// 显示消息
        /// </summary>
        /// <param name="_msg"></param>
        public void Show_Msg(string _msg,int _i_type=0)
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
                    _s_Type="NULL";
                    break;
            }
            Tbx_Msg.BeginInvoke(new Action(() =>
            {
                Tbx_Msg.AppendText(DateTime.Now.ToString("[yyyy-MM-dd hh:mm:ss]=>")+ "("+_s_Type+")"
                    + _msg+"\r\n");
                Lab_Success.Text = _i_Success.ToString();
                Lab_Fail.Text = _i_Fail.ToString();
                PgB_Main.Value = (int)((_i_Success + _i_Fail)*100 / (_i_Max_Val-_i_Min_Val));
            }));
        }
    }
}
