namespace FictionScrawl._3_UIL
{
    partial class Frm_Fiction_Chapter_Content
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Fiction_Chapter_Content));
            this.Lab_Chapter_Name = new System.Windows.Forms.Label();
            this.Pal_Read = new System.Windows.Forms.Panel();
            this.Btn_Chapter_Pre = new System.Windows.Forms.Button();
            this.Btn_Chapter_Next = new System.Windows.Forms.Button();
            this.Btn_Chapter_List = new System.Windows.Forms.Button();
            this.Mpgb_Load = new DMSkin.Metro.Controls.MetroProgressSpinner();
            this.Lab_Chapter_Content = new FictionScrawl._3_UIL.MyControl.TransTextBox();
            this.Pal_Read.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lab_Chapter_Name
            // 
            this.Lab_Chapter_Name.AutoSize = true;
            this.Lab_Chapter_Name.BackColor = System.Drawing.Color.Transparent;
            this.Lab_Chapter_Name.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Chapter_Name.Location = new System.Drawing.Point(12, 9);
            this.Lab_Chapter_Name.Name = "Lab_Chapter_Name";
            this.Lab_Chapter_Name.Size = new System.Drawing.Size(84, 25);
            this.Lab_Chapter_Name.TabIndex = 0;
            this.Lab_Chapter_Name.Text = "加载中...";
            // 
            // Pal_Read
            // 
            this.Pal_Read.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pal_Read.BackColor = System.Drawing.Color.Transparent;
            this.Pal_Read.Controls.Add(this.Lab_Chapter_Content);
            this.Pal_Read.Location = new System.Drawing.Point(12, 37);
            this.Pal_Read.Name = "Pal_Read";
            this.Pal_Read.Size = new System.Drawing.Size(445, 548);
            this.Pal_Read.TabIndex = 2;
            // 
            // Btn_Chapter_Pre
            // 
            this.Btn_Chapter_Pre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Chapter_Pre.Location = new System.Drawing.Point(12, 591);
            this.Btn_Chapter_Pre.Name = "Btn_Chapter_Pre";
            this.Btn_Chapter_Pre.Size = new System.Drawing.Size(75, 33);
            this.Btn_Chapter_Pre.TabIndex = 3;
            this.Btn_Chapter_Pre.Text = "上一章";
            this.Btn_Chapter_Pre.UseVisualStyleBackColor = true;
            this.Btn_Chapter_Pre.Click += new System.EventHandler(this.Btn_Chapter_Pre_Click);
            // 
            // Btn_Chapter_Next
            // 
            this.Btn_Chapter_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Chapter_Next.Location = new System.Drawing.Point(382, 591);
            this.Btn_Chapter_Next.Name = "Btn_Chapter_Next";
            this.Btn_Chapter_Next.Size = new System.Drawing.Size(75, 33);
            this.Btn_Chapter_Next.TabIndex = 3;
            this.Btn_Chapter_Next.Text = "下一章";
            this.Btn_Chapter_Next.UseVisualStyleBackColor = true;
            this.Btn_Chapter_Next.Click += new System.EventHandler(this.Btn_Chapter_Next_Click);
            // 
            // Btn_Chapter_List
            // 
            this.Btn_Chapter_List.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Chapter_List.Location = new System.Drawing.Point(197, 591);
            this.Btn_Chapter_List.Name = "Btn_Chapter_List";
            this.Btn_Chapter_List.Size = new System.Drawing.Size(75, 33);
            this.Btn_Chapter_List.TabIndex = 3;
            this.Btn_Chapter_List.Text = "返回";
            this.Btn_Chapter_List.UseVisualStyleBackColor = true;
            this.Btn_Chapter_List.Click += new System.EventHandler(this.Btn_Chapter_List_Click);
            // 
            // Mpgb_Load
            // 
            this.Mpgb_Load.DM_Maximum = 100;
            this.Mpgb_Load.DM_UseSelectable = true;
            this.Mpgb_Load.Location = new System.Drawing.Point(432, 9);
            this.Mpgb_Load.Name = "Mpgb_Load";
            this.Mpgb_Load.Size = new System.Drawing.Size(25, 25);
            this.Mpgb_Load.TabIndex = 5;
            // 
            // Lab_Chapter_Content
            // 
            this.Lab_Chapter_Content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lab_Chapter_Content.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Lab_Chapter_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lab_Chapter_Content.Location = new System.Drawing.Point(0, 0);
            this.Lab_Chapter_Content.Multiline = true;
            this.Lab_Chapter_Content.Name = "Lab_Chapter_Content";
            this.Lab_Chapter_Content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Lab_Chapter_Content.Size = new System.Drawing.Size(445, 548);
            this.Lab_Chapter_Content.TabIndex = 0;
            this.Lab_Chapter_Content.Text = "加载中...";
            // 
            // Frm_Fiction_Chapter_Content
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FictionScrawl.Properties.Resources.contentbackpaper;
            this.ClientSize = new System.Drawing.Size(469, 636);
            this.Controls.Add(this.Mpgb_Load);
            this.Controls.Add(this.Btn_Chapter_Next);
            this.Controls.Add(this.Btn_Chapter_List);
            this.Controls.Add(this.Btn_Chapter_Pre);
            this.Controls.Add(this.Pal_Read);
            this.Controls.Add(this.Lab_Chapter_Name);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Fiction_Chapter_Content";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "章节内容";
            this.Load += new System.EventHandler(this.Frm_Fiction_Chapter_Content_Load);
            this.Pal_Read.ResumeLayout(false);
            this.Pal_Read.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab_Chapter_Name;
        private System.Windows.Forms.Panel Pal_Read;
        private System.Windows.Forms.Button Btn_Chapter_Pre;
        private System.Windows.Forms.Button Btn_Chapter_Next;
        private System.Windows.Forms.Button Btn_Chapter_List;
        private DMSkin.Metro.Controls.MetroProgressSpinner Mpgb_Load;
        private MyControl.TransTextBox Lab_Chapter_Content;
    }
}