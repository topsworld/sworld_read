namespace FictionScrawl._3_UIL
{
    partial class Frm_Fiction_Detail_Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Fiction_Detail_Info));
            this.Lab_Fiction_Name = new System.Windows.Forms.Label();
            this.Lv_Chapter_List = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lab_Fiction_Introduction = new System.Windows.Forms.Label();
            this.Lab_Update_Time = new System.Windows.Forms.Label();
            this.Lab_Fiction_Author = new System.Windows.Forms.Label();
            this.Lab_Fiction_Type = new System.Windows.Forms.Label();
            this.Mpgb_Load = new DMSkin.Metro.Controls.MetroProgressSpinner();
            this.Pal_Main = new System.Windows.Forms.Panel();
            this.Lab_Update_Chapter = new System.Windows.Forms.LinkLabel();
            this.Btn_Add_BookShelf = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_Download = new System.Windows.Forms.Button();
            this.Lab_Load = new System.Windows.Forms.Label();
            this.Pbx_Fiction_Poster = new System.Windows.Forms.PictureBox();
            this.Pal_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Fiction_Poster)).BeginInit();
            this.SuspendLayout();
            // 
            // Lab_Fiction_Name
            // 
            this.Lab_Fiction_Name.AutoSize = true;
            this.Lab_Fiction_Name.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Fiction_Name.Location = new System.Drawing.Point(144, 12);
            this.Lab_Fiction_Name.Name = "Lab_Fiction_Name";
            this.Lab_Fiction_Name.Size = new System.Drawing.Size(75, 28);
            this.Lab_Fiction_Name.TabIndex = 1;
            this.Lab_Fiction_Name.Text = "小说名";
            // 
            // Lv_Chapter_List
            // 
            this.Lv_Chapter_List.HideSelection = false;
            this.Lv_Chapter_List.Location = new System.Drawing.Point(11, 168);
            this.Lv_Chapter_List.Name = "Lv_Chapter_List";
            this.Lv_Chapter_List.Size = new System.Drawing.Size(661, 281);
            this.Lv_Chapter_List.TabIndex = 2;
            this.Lv_Chapter_List.UseCompatibleStateImageBehavior = false;
            this.Lv_Chapter_List.View = System.Windows.Forms.View.List;
            this.Lv_Chapter_List.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Lv_Chapter_List_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(145, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "作者：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(397, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(397, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "更新时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(145, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "最新章节：";
            // 
            // Lab_Fiction_Introduction
            // 
            this.Lab_Fiction_Introduction.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Fiction_Introduction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lab_Fiction_Introduction.Location = new System.Drawing.Point(149, 101);
            this.Lab_Fiction_Introduction.Name = "Lab_Fiction_Introduction";
            this.Lab_Fiction_Introduction.Size = new System.Drawing.Size(523, 61);
            this.Lab_Fiction_Introduction.TabIndex = 3;
            this.Lab_Fiction_Introduction.Text = "简介";
            // 
            // Lab_Update_Time
            // 
            this.Lab_Update_Time.AutoSize = true;
            this.Lab_Update_Time.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Update_Time.Location = new System.Drawing.Point(482, 75);
            this.Lab_Update_Time.Name = "Lab_Update_Time";
            this.Lab_Update_Time.Size = new System.Drawing.Size(85, 20);
            this.Lab_Update_Time.TabIndex = 3;
            this.Lab_Update_Time.Text = "2019-01-01";
            // 
            // Lab_Fiction_Author
            // 
            this.Lab_Fiction_Author.AutoSize = true;
            this.Lab_Fiction_Author.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Fiction_Author.Location = new System.Drawing.Point(230, 48);
            this.Lab_Fiction_Author.Name = "Lab_Fiction_Author";
            this.Lab_Fiction_Author.Size = new System.Drawing.Size(27, 20);
            this.Lab_Fiction_Author.TabIndex = 3;
            this.Lab_Fiction_Author.Text = "XX";
            // 
            // Lab_Fiction_Type
            // 
            this.Lab_Fiction_Type.AutoSize = true;
            this.Lab_Fiction_Type.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Fiction_Type.Location = new System.Drawing.Point(482, 48);
            this.Lab_Fiction_Type.Name = "Lab_Fiction_Type";
            this.Lab_Fiction_Type.Size = new System.Drawing.Size(45, 20);
            this.Lab_Fiction_Type.TabIndex = 3;
            this.Lab_Fiction_Type.Text = "XXXX";
            // 
            // Mpgb_Load
            // 
            this.Mpgb_Load.DM_Maximum = 100;
            this.Mpgb_Load.DM_UseSelectable = true;
            this.Mpgb_Load.Location = new System.Drawing.Point(315, 144);
            this.Mpgb_Load.Name = "Mpgb_Load";
            this.Mpgb_Load.Size = new System.Drawing.Size(50, 50);
            this.Mpgb_Load.TabIndex = 4;
            // 
            // Pal_Main
            // 
            this.Pal_Main.Controls.Add(this.Lab_Update_Chapter);
            this.Pal_Main.Controls.Add(this.Btn_Add_BookShelf);
            this.Pal_Main.Controls.Add(this.Btn_Close);
            this.Pal_Main.Controls.Add(this.Btn_Download);
            this.Pal_Main.Controls.Add(this.Pbx_Fiction_Poster);
            this.Pal_Main.Controls.Add(this.label4);
            this.Pal_Main.Controls.Add(this.Lab_Fiction_Name);
            this.Pal_Main.Controls.Add(this.Lab_Fiction_Introduction);
            this.Pal_Main.Controls.Add(this.Lv_Chapter_List);
            this.Pal_Main.Controls.Add(this.label3);
            this.Pal_Main.Controls.Add(this.label1);
            this.Pal_Main.Controls.Add(this.label2);
            this.Pal_Main.Controls.Add(this.Lab_Update_Time);
            this.Pal_Main.Controls.Add(this.Lab_Fiction_Type);
            this.Pal_Main.Controls.Add(this.Lab_Fiction_Author);
            this.Pal_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pal_Main.Enabled = false;
            this.Pal_Main.Location = new System.Drawing.Point(0, 0);
            this.Pal_Main.Name = "Pal_Main";
            this.Pal_Main.Size = new System.Drawing.Size(684, 461);
            this.Pal_Main.TabIndex = 5;
            // 
            // Lab_Update_Chapter
            // 
            this.Lab_Update_Chapter.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Update_Chapter.LinkColor = System.Drawing.Color.DodgerBlue;
            this.Lab_Update_Chapter.Location = new System.Drawing.Point(230, 75);
            this.Lab_Update_Chapter.Name = "Lab_Update_Chapter";
            this.Lab_Update_Chapter.Size = new System.Drawing.Size(161, 20);
            this.Lab_Update_Chapter.TabIndex = 5;
            this.Lab_Update_Chapter.TabStop = true;
            this.Lab_Update_Chapter.Text = "XXXX";
            this.Lab_Update_Chapter.VisitedLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.Lab_Update_Chapter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lab_Update_Chapter_LinkClicked);
            // 
            // Btn_Add_BookShelf
            // 
            this.Btn_Add_BookShelf.Location = new System.Drawing.Point(456, 12);
            this.Btn_Add_BookShelf.Name = "Btn_Add_BookShelf";
            this.Btn_Add_BookShelf.Size = new System.Drawing.Size(68, 33);
            this.Btn_Add_BookShelf.TabIndex = 4;
            this.Btn_Add_BookShelf.Text = "书架";
            this.Btn_Add_BookShelf.UseVisualStyleBackColor = true;
            this.Btn_Add_BookShelf.Click += new System.EventHandler(this.Btn_Add_BookShelf_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(604, 12);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(68, 33);
            this.Btn_Close.TabIndex = 4;
            this.Btn_Close.Text = "关闭";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_Download
            // 
            this.Btn_Download.Location = new System.Drawing.Point(530, 12);
            this.Btn_Download.Name = "Btn_Download";
            this.Btn_Download.Size = new System.Drawing.Size(68, 33);
            this.Btn_Download.TabIndex = 4;
            this.Btn_Download.Text = "下载";
            this.Btn_Download.UseVisualStyleBackColor = true;
            this.Btn_Download.Click += new System.EventHandler(this.Btn_Download_Click);
            // 
            // Lab_Load
            // 
            this.Lab_Load.BackColor = System.Drawing.Color.Transparent;
            this.Lab_Load.Location = new System.Drawing.Point(315, 197);
            this.Lab_Load.Name = "Lab_Load";
            this.Lab_Load.Size = new System.Drawing.Size(50, 24);
            this.Lab_Load.TabIndex = 5;
            this.Lab_Load.Text = "加载中";
            this.Lab_Load.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pbx_Fiction_Poster
            // 
            this.Pbx_Fiction_Poster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pbx_Fiction_Poster.Image = global::FictionScrawl.Properties.Resources.backpaper;
            this.Pbx_Fiction_Poster.Location = new System.Drawing.Point(12, 12);
            this.Pbx_Fiction_Poster.Name = "Pbx_Fiction_Poster";
            this.Pbx_Fiction_Poster.Size = new System.Drawing.Size(120, 150);
            this.Pbx_Fiction_Poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Fiction_Poster.TabIndex = 0;
            this.Pbx_Fiction_Poster.TabStop = false;
            // 
            // Frm_Fiction_Detail_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.Mpgb_Load);
            this.Controls.Add(this.Lab_Load);
            this.Controls.Add(this.Pal_Main);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Fiction_Detail_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "详情：";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Fiction_Detail_Info_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Fiction_Detail_Info_Load);
            this.Pal_Main.ResumeLayout(false);
            this.Pal_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Fiction_Poster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pbx_Fiction_Poster;
        private System.Windows.Forms.Label Lab_Fiction_Name;
        private System.Windows.Forms.ListView Lv_Chapter_List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lab_Fiction_Introduction;
        private System.Windows.Forms.Label Lab_Update_Time;
        private System.Windows.Forms.Label Lab_Fiction_Author;
        private System.Windows.Forms.Label Lab_Fiction_Type;
        private DMSkin.Metro.Controls.MetroProgressSpinner Mpgb_Load;
        private System.Windows.Forms.Panel Pal_Main;
        private System.Windows.Forms.Label Lab_Load;
        private System.Windows.Forms.Button Btn_Add_BookShelf;
        private System.Windows.Forms.Button Btn_Download;
        private System.Windows.Forms.LinkLabel Lab_Update_Chapter;
        private System.Windows.Forms.Button Btn_Close;
    }
}