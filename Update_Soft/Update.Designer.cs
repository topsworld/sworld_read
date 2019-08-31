namespace Update_Soft
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.Lab_Msg = new System.Windows.Forms.Label();
            this.Pgb_Process = new System.Windows.Forms.ProgressBar();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Pbx_Logo = new System.Windows.Forms.PictureBox();
            this.Tmr_Img = new System.Windows.Forms.Timer(this.components);
            this.Lab_Process = new System.Windows.Forms.Label();
            this.Lab_Version_Info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Lab_Msg
            // 
            this.Lab_Msg.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Msg.Location = new System.Drawing.Point(100, 219);
            this.Lab_Msg.Name = "Lab_Msg";
            this.Lab_Msg.Size = new System.Drawing.Size(260, 38);
            this.Lab_Msg.TabIndex = 0;
            this.Lab_Msg.Text = "进度1/3：更新软件准备中...";
            this.Lab_Msg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Pgb_Process
            // 
            this.Pgb_Process.Location = new System.Drawing.Point(100, 203);
            this.Pgb_Process.Name = "Pgb_Process";
            this.Pgb_Process.Size = new System.Drawing.Size(260, 10);
            this.Pgb_Process.Step = 1;
            this.Pgb_Process.TabIndex = 1;
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.SystemColors.WindowText;
            this.Btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Location = new System.Drawing.Point(423, 12);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(25, 25);
            this.Btn_Close.TabIndex = 3;
            this.Btn_Close.Text = "X";
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Pbx_Logo
            // 
            this.Pbx_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Pbx_Logo.Image")));
            this.Pbx_Logo.Location = new System.Drawing.Point(166, 41);
            this.Pbx_Logo.Name = "Pbx_Logo";
            this.Pbx_Logo.Size = new System.Drawing.Size(128, 128);
            this.Pbx_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Logo.TabIndex = 2;
            this.Pbx_Logo.TabStop = false;
            this.Pbx_Logo.WaitOnLoad = true;
            // 
            // Tmr_Img
            // 
            this.Tmr_Img.Enabled = true;
            this.Tmr_Img.Tick += new System.EventHandler(this.Tmr_Img_Tick);
            // 
            // Lab_Process
            // 
            this.Lab_Process.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Process.Location = new System.Drawing.Point(130, 176);
            this.Lab_Process.Name = "Lab_Process";
            this.Lab_Process.Size = new System.Drawing.Size(200, 20);
            this.Lab_Process.TabIndex = 4;
            this.Lab_Process.Text = "软件更新中(0%)...";
            this.Lab_Process.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab_Version_Info
            // 
            this.Lab_Version_Info.AutoSize = true;
            this.Lab_Version_Info.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Version_Info.Location = new System.Drawing.Point(3, 260);
            this.Lab_Version_Info.Name = "Lab_Version_Info";
            this.Lab_Version_Info.Size = new System.Drawing.Size(107, 16);
            this.Lab_Version_Info.TabIndex = 5;
            this.Lab_Version_Info.Text = "更新软件信息：Demo";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.CancelButton = this.Btn_Close;
            this.ClientSize = new System.Drawing.Size(460, 280);
            this.Controls.Add(this.Lab_Version_Info);
            this.Controls.Add(this.Lab_Process);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Pbx_Logo);
            this.Controls.Add(this.Pgb_Process);
            this.Controls.Add(this.Lab_Msg);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "软件更新";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Update_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Update_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab_Msg;
        private System.Windows.Forms.ProgressBar Pgb_Process;
        private System.Windows.Forms.PictureBox Pbx_Logo;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Timer Tmr_Img;
        private System.Windows.Forms.Label Lab_Process;
        private System.Windows.Forms.Label Lab_Version_Info;
    }
}

