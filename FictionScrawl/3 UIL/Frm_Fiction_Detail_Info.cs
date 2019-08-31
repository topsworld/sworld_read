using FictionScrawl._0_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FictionScrawl._3_UIL
{
    public partial class Frm_Fiction_Detail_Info : Form
    {
        //小说简略信息
        tb_fiction_info _tfi_Main;
        //小说详情
        tb_fiction_detail_info _tfdi_All_Info;
        //打开方式
        //0：查找界面打开，需要重新提取数据
        //1：书架界面打开，不需要重新提取数据
        //2：下载完成打开，不需要重新提取数据
        int _i_OpenType = 0;

        _4_ScrawlCore._0_BQG.Cls_Fiction_Search _cfs_Search = new _4_ScrawlCore._0_BQG.Cls_Fiction_Search();
        public Frm_Fiction_Detail_Info(tb_fiction_info _tfi )
        {
            InitializeComponent();
            _tfi_Main = _tfi;
            _i_OpenType = 0;
        }

        public Frm_Fiction_Detail_Info(tb_fiction_detail_info _tfdi,int _type=1)
        {
            InitializeComponent();
            _tfdi_All_Info = _tfdi;
            _i_OpenType = _type;
            switch (_i_OpenType)
            {
                case 1://书架界面打开
                    Btn_Add_BookShelf.Enabled = false;
                    break;
                case 2://下载完成打开
                    Btn_Add_BookShelf.Enabled = false;
                    Btn_Download.Enabled = false;
                    break;
            }
            
        }

        /// <summary>
        /// 根据Index获取章节信息实体
        /// </summary>
        /// <param name="_index"></param>
        /// <returns></returns>
        public tb_chapter_list _o_Get_Chapter_Info_By_Index(int _index)
        {
            if (_tfdi_All_Info._ltcl_Chapter!=null&&_tfdi_All_Info._ltcl_Chapter.Count > 0)
                return _tfdi_All_Info._ltcl_Chapter[_index];
            else
                return null;
        }

        public int _i_Get_Chapter_List_Count()
        {
            if (_tfdi_All_Info._ltcl_Chapter != null)
                return _tfdi_All_Info._ltcl_Chapter.Count();
            else
                return 0;
        }

        /// <summary>
        /// 获取小说详细线程
        /// </summary>
        /// <param name="_o"></param>
        public void Thread_Get_Fiction_Detail(object _o)
        {
            if (_i_OpenType == 0)//查找界面打开小数详情
            {
                _tfdi_All_Info = _cfs_Search._o_Get_Fiction_All_Info(_tfi_Main);
            }
            else if (_i_OpenType == 1)//书架界面打开小说详情
            {

            }

            Lv_Chapter_List.BeginInvoke(new Action(() =>
            {
                if (_tfdi_All_Info != null)
                {
                    Lab_Fiction_Name.Text = _tfdi_All_Info._tfi_Fiction.col_fiction_name;
                    this.Text += Lab_Fiction_Name.Text;
                    Lab_Fiction_Author.Text = _tfdi_All_Info._tfi_Fiction.col_fiction_author;
                    Lab_Fiction_Type.Text = _tfdi_All_Info._tfi_Fiction.col_fiction_type;
                    Lab_Update_Chapter.Text = _tfdi_All_Info._tfi_Fiction.col_update_chapter;
                    Lab_Update_Chapter.Tag = _tfdi_All_Info._tfi_Fiction.col_update_chapter_url;
                    Lab_Update_Time.Text = _tfdi_All_Info._tfi_Fiction.col_update_time.ToString("yyyy-MM-dd");
                    Lab_Fiction_Introduction.Text = _tfdi_All_Info._tfi_Fiction.col_fiction_introduction;
                    if (_tfdi_All_Info._s_Poster == null || _tfdi_All_Info._s_Poster == "")
                        Pbx_Fiction_Poster.Image = _tfdi_All_Info._img_Poster;
                    else
                    {
                        Pbx_Fiction_Poster.Image = _2_BLL.Cls_Oprt_Image.Load_Image((_tfdi_All_Info._s_Poster));
                    }
                    Lv_Chapter_List.Items.Clear();
                    foreach (tb_chapter_list _tcl in _tfdi_All_Info._ltcl_Chapter)
                    {
                        ListViewItem _lvi = new ListViewItem(_tcl.col_chapter_name);
                        _lvi.Tag = _tcl;
                        Lv_Chapter_List.Items.Add(_lvi);
                    }
                }
                else
                {
                    Lab_Fiction_Name.Text = "无数据！";
                }
                Lab_Load.Visible = false;
                Mpgb_Load.Visible = false;
                Pal_Main.Enabled = true;
            }));
        }

        private void Frm_Fiction_Detail_Info_Load(object sender, EventArgs e)
        {
            Thread _thread_Load = new Thread(Thread_Get_Fiction_Detail);
            _thread_Load.IsBackground = true;
            _thread_Load.Start(_tfi_Main);
        }

        /// <summary>
        /// 双击预览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lv_Chapter_List_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Lv_Chapter_List.SelectedItems.Count > 0)
            {
                if (this.OwnedForms.Count() > 0)
                {
                    (this.OwnedForms[0] as Frm_Fiction_Chapter_Content).Tcl_Now = 
                        Lv_Chapter_List.SelectedItems[0].Tag as tb_chapter_list;
                    (this.OwnedForms[0] as Frm_Fiction_Chapter_Content).I_Index =
                        Lv_Chapter_List.SelectedItems[0].Index;
                }
                else
                {
                    _3_UIL.Frm_Fiction_Chapter_Content _ffcc = 
                        new Frm_Fiction_Chapter_Content(Lv_Chapter_List.SelectedItems[0].Tag 
                        as tb_chapter_list,Lv_Chapter_List.SelectedItems[0].Index);
                    _ffcc.Text = Lab_Fiction_Name.Text;
                    _ffcc.Owner = this;
                    _ffcc.Show();
                }
            }
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 退出前，需要关闭所有阅读窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Fiction_Detail_Info_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form _f in this.OwnedForms)
            {
                _f.Close();
            }
            if (_i_OpenType == 1)
            {
                //_2_BLL.Cls_Oprt_Bookshelf.Write_Bookshelf_Info(_tfdi_All_Info,);
            }
        }

        /// <summary>
        /// 最新章节点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab_Update_Chapter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Lab_Update_Chapter.Tag != null)
            {
                if (this.OwnedForms.Count() > 0)
                {
                    (this.OwnedForms[0] as Frm_Fiction_Chapter_Content).Tcl_Now =
                        new tb_chapter_list() {
                            col_chapter_url = Lab_Update_Chapter.Tag.ToString(),
                            col_chapter_name = Lab_Update_Chapter.Text };
                    (this.OwnedForms[0] as Frm_Fiction_Chapter_Content).I_Index = _tfdi_All_Info._ltcl_Chapter.Count - 1;
                }
                else
                {
                    _3_UIL.Frm_Fiction_Chapter_Content _ffcc =
                        new Frm_Fiction_Chapter_Content(
                            new tb_chapter_list() {
                                col_chapter_url = Lab_Update_Chapter.Tag.ToString(),
                                col_chapter_name = Lab_Update_Chapter.Text
                            }
                        , _tfdi_All_Info._ltcl_Chapter.Count()-1);
                    _ffcc.Text = Lab_Fiction_Name.Text;
                    _ffcc.Owner = this;
                    _ffcc.Show();
                }
            }
        }

        /// <summary>
        /// 添加至书架
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Add_BookShelf_Click(object sender, EventArgs e)
        {
            Frm_Main _fm = this.Owner as Frm_Main;
            if ( _fm._b_Check_Fiction_IsExit(_tfdi_All_Info._tfi_Fiction))
            {
                _fm.Show_Btm_Msg(string.Format("书架中已存在【{0}】，请勿重复操作！",
                    _tfdi_All_Info._tfi_Fiction.col_fiction_name),2);
                return;
            }
            _fm._o_Fiction_Add_BookShelf(_tfdi_All_Info);
            _fm.Show_Btm_Msg(string.Format("【{0}】已成功添加至书架！",_tfdi_All_Info._tfi_Fiction.col_fiction_name),2);
            
        }
        /// <summary>
        /// 下载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Download_Click(object sender, EventArgs e)
        {
            Frm_Main _fm = this.Owner as Frm_Main;
            if (_fm._b_Check_Download_Fiction_IsExit(_tfdi_All_Info._tfi_Fiction))
            {
                _fm.Show_Btm_Msg(string.Format("下载任务中已存在【{0}】，请勿重复操作！",
                    _tfdi_All_Info._tfi_Fiction.col_fiction_name), 2);
                return;
            }
            _fm._o_Fiction_Add_Download(_tfdi_All_Info);
            _fm.Show_Btm_Msg(string.Format("【{0}】已成功添加至下载任务！", _tfdi_All_Info._tfi_Fiction.col_fiction_name), 2);
        }
    }
}
