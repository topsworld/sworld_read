namespace FictionScrawl._5_Demo
{
    partial class Frm_Demo_Get_Fiction_Info
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
            this.Btn_Get_Info = new System.Windows.Forms.Button();
            this.Tbx_Msg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lab_Success = new System.Windows.Forms.Label();
            this.Lab_Fail = new System.Windows.Forms.Label();
            this.PgB_Main = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.Nud_Min_Val = new System.Windows.Forms.NumericUpDown();
            this.Nud_Max_Val = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Min_Val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Max_Val)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Get_Info
            // 
            this.Btn_Get_Info.Location = new System.Drawing.Point(767, 497);
            this.Btn_Get_Info.Name = "Btn_Get_Info";
            this.Btn_Get_Info.Size = new System.Drawing.Size(105, 52);
            this.Btn_Get_Info.TabIndex = 0;
            this.Btn_Get_Info.Text = "获取";
            this.Btn_Get_Info.UseVisualStyleBackColor = true;
            this.Btn_Get_Info.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Tbx_Msg
            // 
            this.Tbx_Msg.Location = new System.Drawing.Point(12, 12);
            this.Tbx_Msg.Multiline = true;
            this.Tbx_Msg.Name = "Tbx_Msg";
            this.Tbx_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Tbx_Msg.Size = new System.Drawing.Size(860, 474);
            this.Tbx_Msg.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "成功：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(168, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "失败：";
            // 
            // Lab_Success
            // 
            this.Lab_Success.AutoSize = true;
            this.Lab_Success.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Success.ForeColor = System.Drawing.Color.Green;
            this.Lab_Success.Location = new System.Drawing.Point(76, 496);
            this.Lab_Success.Name = "Lab_Success";
            this.Lab_Success.Size = new System.Drawing.Size(20, 22);
            this.Lab_Success.TabIndex = 2;
            this.Lab_Success.Text = "0";
            // 
            // Lab_Fail
            // 
            this.Lab_Fail.AutoSize = true;
            this.Lab_Fail.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Fail.ForeColor = System.Drawing.Color.Red;
            this.Lab_Fail.Location = new System.Drawing.Point(232, 496);
            this.Lab_Fail.Name = "Lab_Fail";
            this.Lab_Fail.Size = new System.Drawing.Size(20, 22);
            this.Lab_Fail.TabIndex = 2;
            this.Lab_Fail.Text = "0";
            // 
            // PgB_Main
            // 
            this.PgB_Main.Location = new System.Drawing.Point(12, 530);
            this.PgB_Main.Name = "PgB_Main";
            this.PgB_Main.Size = new System.Drawing.Size(749, 19);
            this.PgB_Main.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(335, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "范围：";
            // 
            // Nud_Min_Val
            // 
            this.Nud_Min_Val.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Nud_Min_Val.Location = new System.Drawing.Point(399, 495);
            this.Nud_Min_Val.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.Nud_Min_Val.Name = "Nud_Min_Val";
            this.Nud_Min_Val.Size = new System.Drawing.Size(93, 26);
            this.Nud_Min_Val.TabIndex = 5;
            // 
            // Nud_Max_Val
            // 
            this.Nud_Max_Val.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Nud_Max_Val.Location = new System.Drawing.Point(526, 495);
            this.Nud_Max_Val.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.Nud_Max_Val.Name = "Nud_Max_Val";
            this.Nud_Max_Val.Size = new System.Drawing.Size(93, 26);
            this.Nud_Max_Val.TabIndex = 5;
            this.Nud_Max_Val.Value = new decimal(new int[] {
            220000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(498, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "~";
            // 
            // Frm_Demo_Get_Fiction_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.Nud_Max_Val);
            this.Controls.Add(this.Nud_Min_Val);
            this.Controls.Add(this.PgB_Main);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lab_Fail);
            this.Controls.Add(this.Lab_Success);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tbx_Msg);
            this.Controls.Add(this.Btn_Get_Info);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Demo_Get_Fiction_Info";
            this.Text = "获取小说信息";
            this.Load += new System.EventHandler(this.Frm_Demo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Min_Val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Max_Val)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Get_Info;
        private System.Windows.Forms.TextBox Tbx_Msg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lab_Success;
        private System.Windows.Forms.Label Lab_Fail;
        private System.Windows.Forms.ProgressBar PgB_Main;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Nud_Min_Val;
        private System.Windows.Forms.NumericUpDown Nud_Max_Val;
        private System.Windows.Forms.Label label4;
    }
}