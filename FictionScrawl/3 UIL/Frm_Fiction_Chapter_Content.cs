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

namespace FictionScrawl._3_UIL
{
    public partial class Frm_Fiction_Chapter_Content : Form
    {
        _4_ScrawlCore._0_BQG.Cls_Get_Chapter_Content _cgcc = new _4_ScrawlCore._0_BQG.Cls_Get_Chapter_Content();
        Thread _thread_Get;
        int _i_Index = 0;//编号
        public Frm_Fiction_Chapter_Content(tb_chapter_list _tcl,int _index)
        {
            InitializeComponent();
            _tcl_Now = _tcl;
            _i_Index = _index;
        }
        tb_chapter_list _tcl_Now;
        public tb_chapter_list Tcl_Now {
            get => _tcl_Now;
            set
            {
                _tcl_Now = value;
                Frm_Fiction_Chapter_Content_Load(null,null);
            }
        }

        public int I_Index { get => _i_Index; set => _i_Index = value; }

        /// <summary>
        /// 获取章节内容线程
        /// </summary>
        /// <param name="_o"></param>
        public void Thread_Get_Chapter_Content(object _o)
        {
            //实体为null或者内容为空，才需要获取内容
            if (_tcl_Now == null || _tcl_Now.IsDownload == false)
            {
                _tcl_Now.col_chapter_content = _cgcc.Get_Chapter_Content(_tcl_Now.col_chapter_url);
                _tcl_Now.IsDownload = true;//下载完成
            }
            this.BeginInvoke(new Action(()=> 
            {
                if (_tcl_Now != null)
                {
                    Lab_Chapter_Content.Clear();// = "";
                    Lab_Chapter_Content.SelectionStart = 0;
                    Lab_Chapter_Name.Text = _tcl_Now.col_chapter_name;
                    Lab_Chapter_Content.Text = _tcl_Now.col_chapter_content;
                }

                Mpgb_Load.Visible = false;
            }));
        }

        private void Frm_Fiction_Chapter_Content_Load(object sender, EventArgs e)
        {
            if (_thread_Get != null&& _thread_Get.IsAlive)
            {
                _thread_Get.Abort();
                _thread_Get.Join();
                _thread_Get = null;
            }
            Mpgb_Load.Visible = true;
            _thread_Get = new Thread(Thread_Get_Chapter_Content);
            _thread_Get.IsBackground = true;
            _thread_Get.Start();
        }

        /// <summary>
        /// 上一章
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Chapter_Pre_Click(object sender, EventArgs e)
        {
            if (I_Index > 0)
            {
                I_Index -= 1;
                Tcl_Now = (this.Owner as Frm_Fiction_Detail_Info)._o_Get_Chapter_Info_By_Index(I_Index);
            }
        }

        /// <summary>
        /// 目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Chapter_List_Click(object sender, EventArgs e)
        {
            Close();
            //this.Owner.Show();
        }

        /// <summary>
        /// 下一章
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Chapter_Next_Click(object sender, EventArgs e)
        {
            if (I_Index < ((this.Owner as Frm_Fiction_Detail_Info)._i_Get_Chapter_List_Count()-1))
            {
                I_Index += 1;
                Tcl_Now = (this.Owner as Frm_Fiction_Detail_Info)._o_Get_Chapter_Info_By_Index(I_Index);
            }
        }
    }
}
