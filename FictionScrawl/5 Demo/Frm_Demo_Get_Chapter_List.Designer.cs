namespace FictionScrawl._5_Demo
{
    partial class Frm_Demo_Get_Chapter_List
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
            this.PgB_Main = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.Lab_All = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lab_Fail = new System.Windows.Forms.Label();
            this.Lab_Success = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbx_Msg = new System.Windows.Forms.TextBox();
            this.Btn_Get_Fiction_Poster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PgB_Main
            // 
            this.PgB_Main.Location = new System.Drawing.Point(16, 520);
            this.PgB_Main.Name = "PgB_Main";
            this.PgB_Main.Size = new System.Drawing.Size(745, 19);
            this.PgB_Main.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(582, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "总数：";
            // 
            // Lab_All
            // 
            this.Lab_All.AutoSize = true;
            this.Lab_All.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_All.ForeColor = System.Drawing.Color.Red;
            this.Lab_All.Location = new System.Drawing.Point(646, 495);
            this.Lab_All.Name = "Lab_All";
            this.Lab_All.Size = new System.Drawing.Size(20, 22);
            this.Lab_All.TabIndex = 14;
            this.Lab_All.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(204, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "失败：";
            // 
            // Lab_Fail
            // 
            this.Lab_Fail.AutoSize = true;
            this.Lab_Fail.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Fail.ForeColor = System.Drawing.Color.Red;
            this.Lab_Fail.Location = new System.Drawing.Point(268, 495);
            this.Lab_Fail.Name = "Lab_Fail";
            this.Lab_Fail.Size = new System.Drawing.Size(20, 22);
            this.Lab_Fail.TabIndex = 15;
            this.Lab_Fail.Text = "0";
            // 
            // Lab_Success
            // 
            this.Lab_Success.AutoSize = true;
            this.Lab_Success.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Success.ForeColor = System.Drawing.Color.Green;
            this.Lab_Success.Location = new System.Drawing.Point(76, 495);
            this.Lab_Success.Name = "Lab_Success";
            this.Lab_Success.Size = new System.Drawing.Size(20, 22);
            this.Lab_Success.TabIndex = 16;
            this.Lab_Success.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "成功：";
            // 
            // Tbx_Msg
            // 
            this.Tbx_Msg.Location = new System.Drawing.Point(12, 12);
            this.Tbx_Msg.Multiline = true;
            this.Tbx_Msg.Name = "Tbx_Msg";
            this.Tbx_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Tbx_Msg.Size = new System.Drawing.Size(860, 480);
            this.Tbx_Msg.TabIndex = 13;
            // 
            // Btn_Get_Fiction_Poster
            // 
            this.Btn_Get_Fiction_Poster.Location = new System.Drawing.Point(767, 507);
            this.Btn_Get_Fiction_Poster.Name = "Btn_Get_Fiction_Poster";
            this.Btn_Get_Fiction_Poster.Size = new System.Drawing.Size(105, 43);
            this.Btn_Get_Fiction_Poster.TabIndex = 12;
            this.Btn_Get_Fiction_Poster.Text = "获取";
            this.Btn_Get_Fiction_Poster.UseVisualStyleBackColor = true;
            this.Btn_Get_Fiction_Poster.Click += new System.EventHandler(this.Btn_Get_Fiction_Poster_Click);
            // 
            // Frm_Demo_Get_Chapter_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 556);
            this.Controls.Add(this.PgB_Main);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lab_All);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lab_Fail);
            this.Controls.Add(this.Lab_Success);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbx_Msg);
            this.Controls.Add(this.Btn_Get_Fiction_Poster);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Frm_Demo_Get_Chapter_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "获取小说章节信息";
            this.Load += new System.EventHandler(this.Frm_Demo_Get_Chapter_List_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar PgB_Main;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lab_All;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lab_Fail;
        private System.Windows.Forms.Label Lab_Success;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbx_Msg;
        private System.Windows.Forms.Button Btn_Get_Fiction_Poster;
    }
}