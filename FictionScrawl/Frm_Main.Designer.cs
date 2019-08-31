namespace FictionScrawl
{
    partial class Frm_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.Btn_Search = new System.Windows.Forms.Button();
            this.TCtrl_Main = new System.Windows.Forms.TabControl();
            this.TPage_HomePage = new System.Windows.Forms.TabPage();
            this.Tbx_Search = new CCWin.SkinControl.SkinWaterTextBox();
            this.Lab_Load = new System.Windows.Forms.Label();
            this.Mpgb_Search = new DMSkin.Metro.Controls.MetroProgressSpinner();
            this.Lv_HomePage = new System.Windows.Forms.ListView();
            this.col_fiction_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_fiction_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_fiction_author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_update_chapter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_update_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_fiction_stata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_click_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cms_Search = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.详情ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加至书架ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.TPage_BookShelf = new System.Windows.Forms.TabPage();
            this.FlPal_BookShelf = new System.Windows.Forms.FlowLayoutPanel();
            this.Cms_Bookshelf = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.详情ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.下载小说ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空缓存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TPage_Download = new System.Windows.Forms.TabPage();
            this.TbCtrl_Download = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Cms_Download = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Download_ALL_Cancel = new System.Windows.Forms.Button();
            this.Btn_Download_All_Start = new System.Windows.Forms.Button();
            this.Btn_Download_All_Stop = new System.Windows.Forms.Button();
            this.Mpgb_All_Percent = new DMSkin.Metro.Controls.MetroProgressBar();
            this.Lab_All_Percent = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Cms_Downloaded = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开小说ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出TxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除小说ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Download_Clear_Downloaded = new System.Windows.Forms.Button();
            this.Lab_Downloaded_Count_Tip = new System.Windows.Forms.Label();
            this.TPage_Setting = new System.Windows.Forms.TabPage();
            this.LLab_Blog = new System.Windows.Forms.LinkLabel();
            this.LLab_HomePage = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_Save_Config = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Chbx_Auto_Start = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Nud_Download_Queue_Num = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Tbx_Download_Dir = new System.Windows.Forms.TextBox();
            this.Btn_Download_Dir_Select = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nud_Cache_Chapter_Num = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Tbx_Bookshelf_Dir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Bookshelf_Dir_Select = new System.Windows.Forms.Button();
            this.Btn_Cache_Clear = new System.Windows.Forms.Button();
            this.Chbx_Cache_All = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Sts_Main = new System.Windows.Forms.StatusStrip();
            this.TsLab_Btm_Msg = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsLab_Sys_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.Tmr_Btm_Msg = new System.Windows.Forms.Timer(this.components);
            this.Tmr_Sys_Time = new System.Windows.Forms.Timer(this.components);
            this.NfIcon_Btm = new System.Windows.Forms.NotifyIcon(this.components);
            this.Img_BookShelf = new System.Windows.Forms.ImageList(this.components);
            this.Sfd_Output_To_Txt = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.Lve_Download = new FictionScrawl._3_UIL.MyControl.ListViewEx();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lve_Downloaded = new FictionScrawl._3_UIL.MyControl.ListViewEx();
            this.col_download_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_download_author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_download_percent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_download_stata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label12 = new System.Windows.Forms.Label();
            this.Nud_Download_Max_Thread = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.LLab_QQ = new System.Windows.Forms.LinkLabel();
            this.TCtrl_Main.SuspendLayout();
            this.TPage_HomePage.SuspendLayout();
            this.Cms_Search.SuspendLayout();
            this.TPage_BookShelf.SuspendLayout();
            this.Cms_Bookshelf.SuspendLayout();
            this.TPage_Download.SuspendLayout();
            this.TbCtrl_Download.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Cms_Download.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Cms_Downloaded.SuspendLayout();
            this.TPage_Setting.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Download_Queue_Num)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Cache_Chapter_Num)).BeginInit();
            this.Sts_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Download_Max_Thread)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Search
            // 
            this.Btn_Search.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Search.Location = new System.Drawing.Point(654, 17);
            this.Btn_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(70, 34);
            this.Btn_Search.TabIndex = 1;
            this.Btn_Search.Text = "查找";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // TCtrl_Main
            // 
            this.TCtrl_Main.Controls.Add(this.TPage_HomePage);
            this.TCtrl_Main.Controls.Add(this.TPage_BookShelf);
            this.TCtrl_Main.Controls.Add(this.TPage_Download);
            this.TCtrl_Main.Controls.Add(this.TPage_Setting);
            this.TCtrl_Main.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TCtrl_Main.ItemSize = new System.Drawing.Size(220, 28);
            this.TCtrl_Main.Location = new System.Drawing.Point(0, 0);
            this.TCtrl_Main.Name = "TCtrl_Main";
            this.TCtrl_Main.SelectedIndex = 0;
            this.TCtrl_Main.Size = new System.Drawing.Size(884, 533);
            this.TCtrl_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TCtrl_Main.TabIndex = 1;
            // 
            // TPage_HomePage
            // 
            this.TPage_HomePage.Controls.Add(this.Tbx_Search);
            this.TPage_HomePage.Controls.Add(this.Lab_Load);
            this.TPage_HomePage.Controls.Add(this.Mpgb_Search);
            this.TPage_HomePage.Controls.Add(this.Lv_HomePage);
            this.TPage_HomePage.Controls.Add(this.label1);
            this.TPage_HomePage.Controls.Add(this.Btn_Search);
            this.TPage_HomePage.Location = new System.Drawing.Point(4, 32);
            this.TPage_HomePage.Name = "TPage_HomePage";
            this.TPage_HomePage.Padding = new System.Windows.Forms.Padding(3);
            this.TPage_HomePage.Size = new System.Drawing.Size(876, 497);
            this.TPage_HomePage.TabIndex = 0;
            this.TPage_HomePage.Text = "首页";
            this.TPage_HomePage.UseVisualStyleBackColor = true;
            // 
            // Tbx_Search
            // 
            this.Tbx_Search.Location = new System.Drawing.Point(269, 21);
            this.Tbx_Search.Name = "Tbx_Search";
            this.Tbx_Search.Size = new System.Drawing.Size(379, 26);
            this.Tbx_Search.TabIndex = 7;
            this.Tbx_Search.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Tbx_Search.WaterText = "关键词";
            // 
            // Lab_Load
            // 
            this.Lab_Load.BackColor = System.Drawing.Color.Transparent;
            this.Lab_Load.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Load.Location = new System.Drawing.Point(415, 247);
            this.Lab_Load.Name = "Lab_Load";
            this.Lab_Load.Size = new System.Drawing.Size(50, 24);
            this.Lab_Load.TabIndex = 6;
            this.Lab_Load.Text = "加载中";
            this.Lab_Load.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lab_Load.Visible = false;
            // 
            // Mpgb_Search
            // 
            this.Mpgb_Search.DM_Maximum = 100;
            this.Mpgb_Search.DM_UseSelectable = true;
            this.Mpgb_Search.Location = new System.Drawing.Point(415, 194);
            this.Mpgb_Search.Name = "Mpgb_Search";
            this.Mpgb_Search.Size = new System.Drawing.Size(50, 50);
            this.Mpgb_Search.TabIndex = 3;
            this.Mpgb_Search.Visible = false;
            // 
            // Lv_HomePage
            // 
            this.Lv_HomePage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_fiction_type,
            this.col_fiction_name,
            this.col_fiction_author,
            this.col_update_chapter,
            this.col_update_time,
            this.col_fiction_stata,
            this.col_click_count});
            this.Lv_HomePage.ContextMenuStrip = this.Cms_Search;
            this.Lv_HomePage.FullRowSelect = true;
            this.Lv_HomePage.HideSelection = false;
            this.Lv_HomePage.Location = new System.Drawing.Point(8, 67);
            this.Lv_HomePage.Name = "Lv_HomePage";
            this.Lv_HomePage.Size = new System.Drawing.Size(860, 427);
            this.Lv_HomePage.TabIndex = 2;
            this.Lv_HomePage.UseCompatibleStateImageBehavior = false;
            this.Lv_HomePage.View = System.Windows.Forms.View.Details;
            this.Lv_HomePage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Lv_HomePage_MouseDoubleClick);
            // 
            // col_fiction_type
            // 
            this.col_fiction_type.Text = "作品分类";
            this.col_fiction_type.Width = 90;
            // 
            // col_fiction_name
            // 
            this.col_fiction_name.Text = "作品名称";
            this.col_fiction_name.Width = 250;
            // 
            // col_fiction_author
            // 
            this.col_fiction_author.Text = "作者";
            this.col_fiction_author.Width = 100;
            // 
            // col_update_chapter
            // 
            this.col_update_chapter.Text = "最新章节";
            this.col_update_chapter.Width = 100;
            // 
            // col_update_time
            // 
            this.col_update_time.Text = "更新时间";
            this.col_update_time.Width = 130;
            // 
            // col_fiction_stata
            // 
            this.col_fiction_stata.Text = "状态";
            this.col_fiction_stata.Width = 80;
            // 
            // col_click_count
            // 
            this.col_click_count.Text = "点击";
            this.col_click_count.Width = 80;
            // 
            // Cms_Search
            // 
            this.Cms_Search.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.详情ToolStripMenuItem,
            this.添加至书架ToolStripMenuItem,
            this.下载ToolStripMenuItem});
            this.Cms_Search.Name = "Cms_Search";
            this.Cms_Search.Size = new System.Drawing.Size(137, 70);
            // 
            // 详情ToolStripMenuItem
            // 
            this.详情ToolStripMenuItem.Name = "详情ToolStripMenuItem";
            this.详情ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.详情ToolStripMenuItem.Text = "小说详情";
            this.详情ToolStripMenuItem.Click += new System.EventHandler(this.详情ToolStripMenuItem_Click);
            // 
            // 添加至书架ToolStripMenuItem
            // 
            this.添加至书架ToolStripMenuItem.Name = "添加至书架ToolStripMenuItem";
            this.添加至书架ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.添加至书架ToolStripMenuItem.Text = "添加至书架";
            this.添加至书架ToolStripMenuItem.Click += new System.EventHandler(this.添加至书架ToolStripMenuItem_Click);
            // 
            // 下载ToolStripMenuItem
            // 
            this.下载ToolStripMenuItem.Name = "下载ToolStripMenuItem";
            this.下载ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.下载ToolStripMenuItem.Text = "下载小说";
            this.下载ToolStripMenuItem.Click += new System.EventHandler(this.下载ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(141, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "SWorld 阅读";
            // 
            // TPage_BookShelf
            // 
            this.TPage_BookShelf.Controls.Add(this.FlPal_BookShelf);
            this.TPage_BookShelf.Location = new System.Drawing.Point(4, 32);
            this.TPage_BookShelf.Name = "TPage_BookShelf";
            this.TPage_BookShelf.Padding = new System.Windows.Forms.Padding(3);
            this.TPage_BookShelf.Size = new System.Drawing.Size(876, 497);
            this.TPage_BookShelf.TabIndex = 3;
            this.TPage_BookShelf.Text = "书架";
            this.TPage_BookShelf.UseVisualStyleBackColor = true;
            // 
            // FlPal_BookShelf
            // 
            this.FlPal_BookShelf.AutoScroll = true;
            this.FlPal_BookShelf.ContextMenuStrip = this.Cms_Bookshelf;
            this.FlPal_BookShelf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlPal_BookShelf.Location = new System.Drawing.Point(3, 3);
            this.FlPal_BookShelf.Name = "FlPal_BookShelf";
            this.FlPal_BookShelf.Size = new System.Drawing.Size(870, 491);
            this.FlPal_BookShelf.TabIndex = 11;
            // 
            // Cms_Bookshelf
            // 
            this.Cms_Bookshelf.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.详情ToolStripMenuItem1,
            this.下载小说ToolStripMenuItem,
            this.清空缓存ToolStripMenuItem});
            this.Cms_Bookshelf.Name = "Cms_Bookshelf";
            this.Cms_Bookshelf.Size = new System.Drawing.Size(137, 70);
            // 
            // 详情ToolStripMenuItem1
            // 
            this.详情ToolStripMenuItem1.Name = "详情ToolStripMenuItem1";
            this.详情ToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.详情ToolStripMenuItem1.Text = "小说详情";
            this.详情ToolStripMenuItem1.Click += new System.EventHandler(this.详情ToolStripMenuItem1_Click);
            // 
            // 下载小说ToolStripMenuItem
            // 
            this.下载小说ToolStripMenuItem.Name = "下载小说ToolStripMenuItem";
            this.下载小说ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.下载小说ToolStripMenuItem.Text = "下载小说";
            this.下载小说ToolStripMenuItem.Click += new System.EventHandler(this.下载小说ToolStripMenuItem_Click);
            // 
            // 清空缓存ToolStripMenuItem
            // 
            this.清空缓存ToolStripMenuItem.Name = "清空缓存ToolStripMenuItem";
            this.清空缓存ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.清空缓存ToolStripMenuItem.Text = "从书架删除";
            this.清空缓存ToolStripMenuItem.Click += new System.EventHandler(this.清空缓存ToolStripMenuItem_Click);
            // 
            // TPage_Download
            // 
            this.TPage_Download.Controls.Add(this.TbCtrl_Download);
            this.TPage_Download.Location = new System.Drawing.Point(4, 32);
            this.TPage_Download.Name = "TPage_Download";
            this.TPage_Download.Padding = new System.Windows.Forms.Padding(3);
            this.TPage_Download.Size = new System.Drawing.Size(876, 497);
            this.TPage_Download.TabIndex = 1;
            this.TPage_Download.Text = "下载";
            this.TPage_Download.UseVisualStyleBackColor = true;
            // 
            // TbCtrl_Download
            // 
            this.TbCtrl_Download.Controls.Add(this.tabPage1);
            this.TbCtrl_Download.Controls.Add(this.tabPage2);
            this.TbCtrl_Download.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbCtrl_Download.ItemSize = new System.Drawing.Size(300, 25);
            this.TbCtrl_Download.Location = new System.Drawing.Point(3, 3);
            this.TbCtrl_Download.Name = "TbCtrl_Download";
            this.TbCtrl_Download.SelectedIndex = 0;
            this.TbCtrl_Download.Size = new System.Drawing.Size(870, 491);
            this.TbCtrl_Download.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TbCtrl_Download.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Lve_Download);
            this.tabPage1.Controls.Add(this.Btn_Download_ALL_Cancel);
            this.tabPage1.Controls.Add(this.Btn_Download_All_Start);
            this.tabPage1.Controls.Add(this.Btn_Download_All_Stop);
            this.tabPage1.Controls.Add(this.Mpgb_All_Percent);
            this.tabPage1.Controls.Add(this.Lab_All_Percent);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(862, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "正在下载";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Cms_Download
            // 
            this.Cms_Download.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.停止ToolStripMenuItem,
            this.删除任务ToolStripMenuItem});
            this.Cms_Download.Name = "Cms_Download";
            this.Cms_Download.Size = new System.Drawing.Size(125, 70);
            this.Cms_Download.Opening += new System.ComponentModel.CancelEventHandler(this.Cms_Download_Opening);
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.开始ToolStripMenuItem.Text = "继续任务";
            this.开始ToolStripMenuItem.Click += new System.EventHandler(this.开始ToolStripMenuItem_Click);
            // 
            // 停止ToolStripMenuItem
            // 
            this.停止ToolStripMenuItem.Name = "停止ToolStripMenuItem";
            this.停止ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.停止ToolStripMenuItem.Text = "停止任务";
            this.停止ToolStripMenuItem.Click += new System.EventHandler(this.停止ToolStripMenuItem_Click);
            // 
            // 删除任务ToolStripMenuItem
            // 
            this.删除任务ToolStripMenuItem.Name = "删除任务ToolStripMenuItem";
            this.删除任务ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除任务ToolStripMenuItem.Text = "取消任务";
            this.删除任务ToolStripMenuItem.Click += new System.EventHandler(this.删除任务ToolStripMenuItem_Click);
            // 
            // Btn_Download_ALL_Cancel
            // 
            this.Btn_Download_ALL_Cancel.Location = new System.Drawing.Point(781, 7);
            this.Btn_Download_ALL_Cancel.Name = "Btn_Download_ALL_Cancel";
            this.Btn_Download_ALL_Cancel.Size = new System.Drawing.Size(75, 29);
            this.Btn_Download_ALL_Cancel.TabIndex = 7;
            this.Btn_Download_ALL_Cancel.Text = "全部取消";
            this.Btn_Download_ALL_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Download_ALL_Cancel.Click += new System.EventHandler(this.Btn_Download_ALL_Cancel_Click);
            // 
            // Btn_Download_All_Start
            // 
            this.Btn_Download_All_Start.Location = new System.Drawing.Point(619, 7);
            this.Btn_Download_All_Start.Name = "Btn_Download_All_Start";
            this.Btn_Download_All_Start.Size = new System.Drawing.Size(75, 29);
            this.Btn_Download_All_Start.TabIndex = 8;
            this.Btn_Download_All_Start.Text = "全部开始";
            this.Btn_Download_All_Start.UseVisualStyleBackColor = true;
            this.Btn_Download_All_Start.Click += new System.EventHandler(this.Btn_Download_All_Start_Click);
            // 
            // Btn_Download_All_Stop
            // 
            this.Btn_Download_All_Stop.Location = new System.Drawing.Point(700, 7);
            this.Btn_Download_All_Stop.Name = "Btn_Download_All_Stop";
            this.Btn_Download_All_Stop.Size = new System.Drawing.Size(75, 29);
            this.Btn_Download_All_Stop.TabIndex = 8;
            this.Btn_Download_All_Stop.Text = "全部停止";
            this.Btn_Download_All_Stop.UseVisualStyleBackColor = true;
            this.Btn_Download_All_Stop.Click += new System.EventHandler(this.Btn_Download_All_Stop_Click);
            // 
            // Mpgb_All_Percent
            // 
            this.Mpgb_All_Percent.Location = new System.Drawing.Point(105, 14);
            this.Mpgb_All_Percent.Name = "Mpgb_All_Percent";
            this.Mpgb_All_Percent.Size = new System.Drawing.Size(464, 17);
            this.Mpgb_All_Percent.TabIndex = 6;
            // 
            // Lab_All_Percent
            // 
            this.Lab_All_Percent.AutoSize = true;
            this.Lab_All_Percent.Location = new System.Drawing.Point(572, 12);
            this.Lab_All_Percent.Name = "Lab_All_Percent";
            this.Lab_All_Percent.Size = new System.Drawing.Size(29, 20);
            this.Lab_All_Percent.TabIndex = 4;
            this.Lab_All_Percent.Text = "0%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "下载总进度：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Lve_Downloaded);
            this.tabPage2.Controls.Add(this.Btn_Download_Clear_Downloaded);
            this.tabPage2.Controls.Add(this.Lab_Downloaded_Count_Tip);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(862, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "下载成功";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Cms_Downloaded
            // 
            this.Cms_Downloaded.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开小说ToolStripMenuItem,
            this.导出TxtToolStripMenuItem,
            this.删除小说ToolStripMenuItem});
            this.Cms_Downloaded.Name = "contextMenuStrip1";
            this.Cms_Downloaded.Size = new System.Drawing.Size(125, 70);
            this.Cms_Downloaded.Opening += new System.ComponentModel.CancelEventHandler(this.Cms_Downloaded_Opening);
            // 
            // 打开小说ToolStripMenuItem
            // 
            this.打开小说ToolStripMenuItem.Name = "打开小说ToolStripMenuItem";
            this.打开小说ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.打开小说ToolStripMenuItem.Text = "打开小说";
            this.打开小说ToolStripMenuItem.Click += new System.EventHandler(this.打开小说ToolStripMenuItem_Click);
            // 
            // 导出TxtToolStripMenuItem
            // 
            this.导出TxtToolStripMenuItem.Name = "导出TxtToolStripMenuItem";
            this.导出TxtToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.导出TxtToolStripMenuItem.Text = "导出 txt";
            this.导出TxtToolStripMenuItem.Click += new System.EventHandler(this.导出TxtToolStripMenuItem_Click);
            // 
            // 删除小说ToolStripMenuItem
            // 
            this.删除小说ToolStripMenuItem.Name = "删除小说ToolStripMenuItem";
            this.删除小说ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除小说ToolStripMenuItem.Text = "删除小说";
            this.删除小说ToolStripMenuItem.Click += new System.EventHandler(this.删除小说ToolStripMenuItem_Click);
            // 
            // Btn_Download_Clear_Downloaded
            // 
            this.Btn_Download_Clear_Downloaded.Location = new System.Drawing.Point(717, 7);
            this.Btn_Download_Clear_Downloaded.Name = "Btn_Download_Clear_Downloaded";
            this.Btn_Download_Clear_Downloaded.Size = new System.Drawing.Size(139, 29);
            this.Btn_Download_Clear_Downloaded.TabIndex = 11;
            this.Btn_Download_Clear_Downloaded.Text = "清除所有记录";
            this.Btn_Download_Clear_Downloaded.UseVisualStyleBackColor = true;
            this.Btn_Download_Clear_Downloaded.Click += new System.EventHandler(this.Btn_Download_Clear_Downloaded_Click);
            // 
            // Lab_Downloaded_Count_Tip
            // 
            this.Lab_Downloaded_Count_Tip.AutoSize = true;
            this.Lab_Downloaded_Count_Tip.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Downloaded_Count_Tip.Location = new System.Drawing.Point(6, 10);
            this.Lab_Downloaded_Count_Tip.Name = "Lab_Downloaded_Count_Tip";
            this.Lab_Downloaded_Count_Tip.Size = new System.Drawing.Size(115, 21);
            this.Lab_Downloaded_Count_Tip.TabIndex = 10;
            this.Lab_Downloaded_Count_Tip.Text = "共下载0本小说";
            // 
            // TPage_Setting
            // 
            this.TPage_Setting.Controls.Add(this.LLab_QQ);
            this.TPage_Setting.Controls.Add(this.LLab_Blog);
            this.TPage_Setting.Controls.Add(this.label16);
            this.TPage_Setting.Controls.Add(this.LLab_HomePage);
            this.TPage_Setting.Controls.Add(this.label10);
            this.TPage_Setting.Controls.Add(this.label9);
            this.TPage_Setting.Controls.Add(this.label8);
            this.TPage_Setting.Controls.Add(this.Btn_Save_Config);
            this.TPage_Setting.Controls.Add(this.label7);
            this.TPage_Setting.Controls.Add(this.groupBox3);
            this.TPage_Setting.Controls.Add(this.groupBox2);
            this.TPage_Setting.Controls.Add(this.groupBox1);
            this.TPage_Setting.Controls.Add(this.label6);
            this.TPage_Setting.Location = new System.Drawing.Point(4, 32);
            this.TPage_Setting.Name = "TPage_Setting";
            this.TPage_Setting.Padding = new System.Windows.Forms.Padding(3);
            this.TPage_Setting.Size = new System.Drawing.Size(876, 497);
            this.TPage_Setting.TabIndex = 2;
            this.TPage_Setting.Text = "设置";
            this.TPage_Setting.UseVisualStyleBackColor = true;
            // 
            // LLab_Blog
            // 
            this.LLab_Blog.AutoSize = true;
            this.LLab_Blog.LinkColor = System.Drawing.Color.DodgerBlue;
            this.LLab_Blog.Location = new System.Drawing.Point(403, 465);
            this.LLab_Blog.Name = "LLab_Blog";
            this.LLab_Blog.Size = new System.Drawing.Size(257, 20);
            this.LLab_Blog.TabIndex = 7;
            this.LLab_Blog.TabStop = true;
            this.LLab_Blog.Text = "http://blog.csdn.net/baidu_26678247";
            this.LLab_Blog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLab_Blog_LinkClicked);
            // 
            // LLab_HomePage
            // 
            this.LLab_HomePage.AutoSize = true;
            this.LLab_HomePage.LinkColor = System.Drawing.Color.DodgerBlue;
            this.LLab_HomePage.Location = new System.Drawing.Point(99, 465);
            this.LLab_HomePage.Name = "LLab_HomePage";
            this.LLab_HomePage.Size = new System.Drawing.Size(115, 20);
            this.LLab_HomePage.TabIndex = 7;
            this.LLab_HomePage.TabStop = true;
            this.LLab_HomePage.Text = "www.sworld.top";
            this.LLab_HomePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLab_HomePage_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "博客链接：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "个人网站：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(317, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "如果在使用过程中遇到任何问题，请与作者联系。";
            // 
            // Btn_Save_Config
            // 
            this.Btn_Save_Config.Location = new System.Drawing.Point(784, 416);
            this.Btn_Save_Config.Name = "Btn_Save_Config";
            this.Btn_Save_Config.Size = new System.Drawing.Size(84, 44);
            this.Btn_Save_Config.TabIndex = 2;
            this.Btn_Save_Config.Text = "保存设置";
            this.Btn_Save_Config.UseVisualStyleBackColor = true;
            this.Btn_Save_Config.Click += new System.EventHandler(this.Btn_Save_Config_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(473, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "本软件所有资源均来自网络，请大家支持正版，在下载后24小时以内删除。";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Chbx_Auto_Start);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(8, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(860, 66);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "系统设置";
            // 
            // Chbx_Auto_Start
            // 
            this.Chbx_Auto_Start.AutoSize = true;
            this.Chbx_Auto_Start.Location = new System.Drawing.Point(10, 30);
            this.Chbx_Auto_Start.Name = "Chbx_Auto_Start";
            this.Chbx_Auto_Start.Size = new System.Drawing.Size(84, 24);
            this.Chbx_Auto_Start.TabIndex = 1;
            this.Chbx_Auto_Start.Text = "开机自启";
            this.Chbx_Auto_Start.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Nud_Download_Max_Thread);
            this.groupBox2.Controls.Add(this.Nud_Download_Queue_Num);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Tbx_Download_Dir);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.Btn_Download_Dir_Select);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(8, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(860, 152);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "下载设置";
            // 
            // Nud_Download_Queue_Num
            // 
            this.Nud_Download_Queue_Num.Location = new System.Drawing.Point(10, 50);
            this.Nud_Download_Queue_Num.Name = "Nud_Download_Queue_Num";
            this.Nud_Download_Queue_Num.Size = new System.Drawing.Size(120, 26);
            this.Nud_Download_Queue_Num.TabIndex = 4;
            this.Nud_Download_Queue_Num.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "下载存放目录：";
            // 
            // Tbx_Download_Dir
            // 
            this.Tbx_Download_Dir.Enabled = false;
            this.Tbx_Download_Dir.Location = new System.Drawing.Point(10, 110);
            this.Tbx_Download_Dir.Name = "Tbx_Download_Dir";
            this.Tbx_Download_Dir.Size = new System.Drawing.Size(786, 26);
            this.Tbx_Download_Dir.TabIndex = 1;
            // 
            // Btn_Download_Dir_Select
            // 
            this.Btn_Download_Dir_Select.Location = new System.Drawing.Point(802, 107);
            this.Btn_Download_Dir_Select.Name = "Btn_Download_Dir_Select";
            this.Btn_Download_Dir_Select.Size = new System.Drawing.Size(52, 32);
            this.Btn_Download_Dir_Select.TabIndex = 2;
            this.Btn_Download_Dir_Select.Text = "...";
            this.Btn_Download_Dir_Select.UseVisualStyleBackColor = true;
            this.Btn_Download_Dir_Select.Click += new System.EventHandler(this.Btn_Download_Dir_Select_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "下载队列大小：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Nud_Cache_Chapter_Num);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Tbx_Bookshelf_Dir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Btn_Bookshelf_Dir_Select);
            this.groupBox1.Controls.Add(this.Btn_Cache_Clear);
            this.groupBox1.Controls.Add(this.Chbx_Cache_All);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 150);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "阅读设置";
            // 
            // Nud_Cache_Chapter_Num
            // 
            this.Nud_Cache_Chapter_Num.Location = new System.Drawing.Point(10, 50);
            this.Nud_Cache_Chapter_Num.Name = "Nud_Cache_Chapter_Num";
            this.Nud_Cache_Chapter_Num.Size = new System.Drawing.Size(120, 26);
            this.Nud_Cache_Chapter_Num.TabIndex = 4;
            this.Nud_Cache_Chapter_Num.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "书架缓存目录：";
            // 
            // Tbx_Bookshelf_Dir
            // 
            this.Tbx_Bookshelf_Dir.Enabled = false;
            this.Tbx_Bookshelf_Dir.Location = new System.Drawing.Point(10, 109);
            this.Tbx_Bookshelf_Dir.Name = "Tbx_Bookshelf_Dir";
            this.Tbx_Bookshelf_Dir.Size = new System.Drawing.Size(786, 26);
            this.Tbx_Bookshelf_Dir.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "阅读缓存章节数：";
            // 
            // Btn_Bookshelf_Dir_Select
            // 
            this.Btn_Bookshelf_Dir_Select.Location = new System.Drawing.Point(802, 106);
            this.Btn_Bookshelf_Dir_Select.Name = "Btn_Bookshelf_Dir_Select";
            this.Btn_Bookshelf_Dir_Select.Size = new System.Drawing.Size(52, 32);
            this.Btn_Bookshelf_Dir_Select.TabIndex = 2;
            this.Btn_Bookshelf_Dir_Select.Text = "...";
            this.Btn_Bookshelf_Dir_Select.UseVisualStyleBackColor = true;
            this.Btn_Bookshelf_Dir_Select.Click += new System.EventHandler(this.Btn_Cache_Dir_Select_Click);
            // 
            // Btn_Cache_Clear
            // 
            this.Btn_Cache_Clear.Location = new System.Drawing.Point(770, 46);
            this.Btn_Cache_Clear.Name = "Btn_Cache_Clear";
            this.Btn_Cache_Clear.Size = new System.Drawing.Size(84, 32);
            this.Btn_Cache_Clear.TabIndex = 2;
            this.Btn_Cache_Clear.Text = "清空缓存";
            this.Btn_Cache_Clear.UseVisualStyleBackColor = true;
            this.Btn_Cache_Clear.Click += new System.EventHandler(this.Btn_Cache_Clear_Click);
            // 
            // Chbx_Cache_All
            // 
            this.Chbx_Cache_All.AutoSize = true;
            this.Chbx_Cache_All.Location = new System.Drawing.Point(171, 51);
            this.Chbx_Cache_All.Name = "Chbx_Cache_All";
            this.Chbx_Cache_All.Size = new System.Drawing.Size(84, 24);
            this.Chbx_Cache_All.TabIndex = 1;
            this.Chbx_Cache_All.Text = "缓存整本";
            this.Chbx_Cache_All.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(8, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 3;
            this.label6.Text = "声明：";
            // 
            // Sts_Main
            // 
            this.Sts_Main.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Sts_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsLab_Btm_Msg,
            this.TsLab_Sys_Time});
            this.Sts_Main.Location = new System.Drawing.Point(0, 536);
            this.Sts_Main.Name = "Sts_Main";
            this.Sts_Main.Size = new System.Drawing.Size(884, 25);
            this.Sts_Main.SizingGrip = false;
            this.Sts_Main.TabIndex = 3;
            // 
            // TsLab_Btm_Msg
            // 
            this.TsLab_Btm_Msg.Name = "TsLab_Btm_Msg";
            this.TsLab_Btm_Msg.Size = new System.Drawing.Size(696, 20);
            this.TsLab_Btm_Msg.Spring = true;
            this.TsLab_Btm_Msg.Text = "就绪！";
            this.TsLab_Btm_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TsLab_Sys_Time
            // 
            this.TsLab_Sys_Time.Name = "TsLab_Sys_Time";
            this.TsLab_Sys_Time.Size = new System.Drawing.Size(173, 20);
            this.TsLab_Sys_Time.Text = "2019年01月01日 00:00:00";
            // 
            // Tmr_Btm_Msg
            // 
            this.Tmr_Btm_Msg.Interval = 3000;
            this.Tmr_Btm_Msg.Tick += new System.EventHandler(this.Tmr_Btm_Msg_Tick);
            // 
            // Tmr_Sys_Time
            // 
            this.Tmr_Sys_Time.Enabled = true;
            this.Tmr_Sys_Time.Interval = 1000;
            this.Tmr_Sys_Time.Tick += new System.EventHandler(this.Tmr_Sys_Time_Tick);
            // 
            // NfIcon_Btm
            // 
            this.NfIcon_Btm.BalloonTipText = "111";
            this.NfIcon_Btm.BalloonTipTitle = "222";
            this.NfIcon_Btm.Icon = ((System.Drawing.Icon)(resources.GetObject("NfIcon_Btm.Icon")));
            this.NfIcon_Btm.Text = "SWorld 阅读";
            this.NfIcon_Btm.Visible = true;
            // 
            // Img_BookShelf
            // 
            this.Img_BookShelf.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.Img_BookShelf.ImageSize = new System.Drawing.Size(120, 150);
            this.Img_BookShelf.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Sfd_Output_To_Txt
            // 
            this.Sfd_Output_To_Txt.Filter = "文本文件(*.txt)|*.txt";
            this.Sfd_Output_To_Txt.Title = "导出 txt";
            // 
            // Lve_Download
            // 
            this.Lve_Download.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.Lve_Download.ContextMenuStrip = this.Cms_Download;
            this.Lve_Download.FullRowSelect = true;
            this.Lve_Download.HideSelection = false;
            this.Lve_Download.Location = new System.Drawing.Point(6, 42);
            this.Lve_Download.Name = "Lve_Download";
            this.Lve_Download.OwnerDraw = true;
            this.Lve_Download.ProgressColor = System.Drawing.Color.Goldenrod;
            this.Lve_Download.ProgressColumIndex = 2;
            this.Lve_Download.ProgressTextColor = System.Drawing.Color.Black;
            this.Lve_Download.Size = new System.Drawing.Size(850, 410);
            this.Lve_Download.TabIndex = 13;
            this.Lve_Download.UseCompatibleStateImageBehavior = false;
            this.Lve_Download.View = System.Windows.Forms.View.Details;
            this.Lve_Download.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Lve_Download_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "书名";
            this.columnHeader1.Width = 320;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "作者";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "进度";
            this.columnHeader3.Width = 220;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "状态";
            this.columnHeader4.Width = 150;
            // 
            // Lve_Downloaded
            // 
            this.Lve_Downloaded.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_download_name,
            this.col_download_author,
            this.col_download_percent,
            this.col_download_stata});
            this.Lve_Downloaded.ContextMenuStrip = this.Cms_Downloaded;
            this.Lve_Downloaded.FullRowSelect = true;
            this.Lve_Downloaded.HideSelection = false;
            this.Lve_Downloaded.Location = new System.Drawing.Point(6, 42);
            this.Lve_Downloaded.Name = "Lve_Downloaded";
            this.Lve_Downloaded.OwnerDraw = true;
            this.Lve_Downloaded.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.Lve_Downloaded.ProgressColumIndex = 2;
            this.Lve_Downloaded.ProgressTextColor = System.Drawing.Color.Black;
            this.Lve_Downloaded.Size = new System.Drawing.Size(850, 410);
            this.Lve_Downloaded.TabIndex = 12;
            this.Lve_Downloaded.UseCompatibleStateImageBehavior = false;
            this.Lve_Downloaded.View = System.Windows.Forms.View.Details;
            this.Lve_Downloaded.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Lve_Downloaded_MouseDoubleClick);
            // 
            // col_download_name
            // 
            this.col_download_name.Text = "书名";
            this.col_download_name.Width = 320;
            // 
            // col_download_author
            // 
            this.col_download_author.Text = "作者";
            this.col_download_author.Width = 120;
            // 
            // col_download_percent
            // 
            this.col_download_percent.Text = "进度";
            this.col_download_percent.Width = 220;
            // 
            // col_download_stata
            // 
            this.col_download_stata.Text = "状态";
            this.col_download_stata.Width = 150;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(412, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "下载最大线程数：";
            // 
            // Nud_Download_Max_Thread
            // 
            this.Nud_Download_Max_Thread.Location = new System.Drawing.Point(416, 50);
            this.Nud_Download_Max_Thread.Name = "Nud_Download_Max_Thread";
            this.Nud_Download_Max_Thread.Size = new System.Drawing.Size(120, 26);
            this.Nud_Download_Max_Thread.TabIndex = 4;
            this.Nud_Download_Max_Thread.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(640, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "版本信息：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(817, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "V1.0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(725, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "SWorld阅读";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(736, 465);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 20);
            this.label16.TabIndex = 6;
            this.label16.Text = "QQ：";
            // 
            // LLab_QQ
            // 
            this.LLab_QQ.AutoSize = true;
            this.LLab_QQ.LinkColor = System.Drawing.Color.DodgerBlue;
            this.LLab_QQ.Location = new System.Drawing.Point(787, 465);
            this.LLab_QQ.Name = "LLab_QQ";
            this.LLab_QQ.Size = new System.Drawing.Size(81, 20);
            this.LLab_QQ.TabIndex = 7;
            this.LLab_QQ.TabStop = true;
            this.LLab_QQ.Text = "970076933";
            this.LLab_QQ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLab_QQ_LinkClicked);
            // 
            // Frm_Main
            // 
            this.AcceptButton = this.Btn_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.Sts_Main);
            this.Controls.Add(this.TCtrl_Main);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SWorld 阅读";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.TCtrl_Main.ResumeLayout(false);
            this.TPage_HomePage.ResumeLayout(false);
            this.TPage_HomePage.PerformLayout();
            this.Cms_Search.ResumeLayout(false);
            this.TPage_BookShelf.ResumeLayout(false);
            this.Cms_Bookshelf.ResumeLayout(false);
            this.TPage_Download.ResumeLayout(false);
            this.TbCtrl_Download.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Cms_Download.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Cms_Downloaded.ResumeLayout(false);
            this.TPage_Setting.ResumeLayout(false);
            this.TPage_Setting.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Download_Queue_Num)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Cache_Chapter_Num)).EndInit();
            this.Sts_Main.ResumeLayout(false);
            this.Sts_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Download_Max_Thread)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.TabControl TCtrl_Main;
        private System.Windows.Forms.TabPage TPage_HomePage;
        private System.Windows.Forms.TabPage TPage_Download;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView Lv_HomePage;
        private System.Windows.Forms.ColumnHeader col_fiction_type;
        private System.Windows.Forms.ColumnHeader col_fiction_name;
        private System.Windows.Forms.ColumnHeader col_fiction_author;
        private System.Windows.Forms.ColumnHeader col_update_chapter;
        private System.Windows.Forms.ColumnHeader col_update_time;
        private System.Windows.Forms.ColumnHeader col_fiction_stata;
        private System.Windows.Forms.ColumnHeader col_click_count;
        private System.Windows.Forms.ContextMenuStrip Cms_Search;
        private System.Windows.Forms.ToolStripMenuItem 详情ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下载ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip Sts_Main;
        private System.Windows.Forms.ToolStripStatusLabel TsLab_Btm_Msg;
        private DMSkin.Metro.Controls.MetroProgressSpinner Mpgb_Search;
        private System.Windows.Forms.Timer Tmr_Btm_Msg;
        private System.Windows.Forms.TabPage TPage_BookShelf;
        private System.Windows.Forms.TabPage TPage_Setting;
        private System.Windows.Forms.ToolStripMenuItem 添加至书架ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel TsLab_Sys_Time;
        private System.Windows.Forms.Timer Tmr_Sys_Time;
        private System.Windows.Forms.NotifyIcon NfIcon_Btm;
        private System.Windows.Forms.Label Lab_Load;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Cache_Clear;
        private System.Windows.Forms.CheckBox Chbx_Cache_All;
        private System.Windows.Forms.NumericUpDown Nud_Cache_Chapter_Num;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox Chbx_Auto_Start;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown Nud_Download_Queue_Num;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tbx_Download_Dir;
        private System.Windows.Forms.Button Btn_Download_Dir_Select;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel LLab_Blog;
        private System.Windows.Forms.LinkLabel LLab_HomePage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl TbCtrl_Download;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Btn_Download_ALL_Cancel;
        private System.Windows.Forms.Button Btn_Download_All_Stop;
        private DMSkin.Metro.Controls.MetroProgressBar Mpgb_All_Percent;
        private System.Windows.Forms.Label Lab_All_Percent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Btn_Download_Clear_Downloaded;
        private System.Windows.Forms.Label Lab_Downloaded_Count_Tip;
        private System.Windows.Forms.ImageList Img_BookShelf;
        private System.Windows.Forms.Button Btn_Save_Config;
        private CCWin.SkinControl.SkinWaterTextBox Tbx_Search;
        private System.Windows.Forms.FlowLayoutPanel FlPal_BookShelf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tbx_Bookshelf_Dir;
        private System.Windows.Forms.Button Btn_Bookshelf_Dir_Select;
        private System.Windows.Forms.ContextMenuStrip Cms_Bookshelf;
        private System.Windows.Forms.ToolStripMenuItem 详情ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 下载小说ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空缓存ToolStripMenuItem;
        private System.Windows.Forms.Button Btn_Download_All_Start;
        private _3_UIL.MyControl.ListViewEx Lve_Downloaded;
        private System.Windows.Forms.ColumnHeader col_download_name;
        private System.Windows.Forms.ColumnHeader col_download_author;
        private System.Windows.Forms.ColumnHeader col_download_percent;
        private System.Windows.Forms.ColumnHeader col_download_stata;
        private _3_UIL.MyControl.ListViewEx Lve_Download;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip Cms_Download;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除任务ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Cms_Downloaded;
        private System.Windows.Forms.ToolStripMenuItem 打开小说ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出TxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除小说ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog Sfd_Output_To_Txt;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.NumericUpDown Nud_Download_Max_Thread;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.LinkLabel LLab_QQ;
        private System.Windows.Forms.Label label16;
    }
}

