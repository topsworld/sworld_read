using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace FictionScrawl._3_UIL.MyControl
{
    [DefaultEvent("Item_Double_Click")]
    public class BookShelf : UserControl
    {

        public BookShelf()
        {
            InitializeComponent();
        }

        #region 变量
        private int _infoOpacity = 120;
        private PictureBox PbxPoster;
        private Label Lab_Name;
        private bool _isSelect=false;
        #endregion

        #region 属性
        
        /// <summary>
        /// 是否选择
        /// </summary>
        public bool IsSelect { get => _isSelect;}
        /// <summary>
        /// 信息框背景色透明度
        /// </summary>
        [Description("信息框背景色透明度")]
        public int InfoOpacity
        {
            set
            {
                _infoOpacity = value;
                this.Invalidate();
            }
            get { return _infoOpacity; }
        }

        /// <summary>
        /// 显示文本
        /// </summary>
        [Description("显示文本")]
        public string ShowText
        {
            set { Lab_Name.Text = value; }
            get { return Lab_Name.Text; }
        }

        /// <summary>
        /// 显示文本颜色
        /// </summary>
        [Description("显示文本颜色")]
        public Color ShowTextColor
        {
            set { Lab_Name.ForeColor = value; }
            get { return Lab_Name.ForeColor; }
        }

        /// <summary>
        /// 显示文本背景颜色
        /// </summary>
        [Description("显示文本背景颜色")]
        public Color ShowTextBackColor
        {
            set { Lab_Name.BackColor = value; }
            get { return Lab_Name.BackColor; }
        }


        /// <summary>
        /// 信息框背景色
        /// </summary>
        [Description("显示图片")]
        public Image Image {
            set { PbxPoster.Image = value; }
            get { return PbxPoster.Image; }
        }


        /// <summary>
        /// 加载图片文件
        /// </summary>
        /// <param name="_path"></param>
        public void Load_Image(string _path)
        {
            if (_path != null && File.Exists(_path))
            {
                PbxPoster.Image = _2_BLL.Cls_Oprt_Image.Load_Image(_path);
            }
        }


        #endregion


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookShelf));
            this.Lab_Name = new System.Windows.Forms.Label();
            this.PbxPoster = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // Lab_Name
            // 
            this.Lab_Name.BackColor = System.Drawing.Color.Transparent;
            this.Lab_Name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Name.Location = new System.Drawing.Point(0, 150);
            this.Lab_Name.Name = "Lab_Name";
            this.Lab_Name.Size = new System.Drawing.Size(120, 40);
            this.Lab_Name.TabIndex = 0;
            this.Lab_Name.Text = "ShowText";
            this.Lab_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lab_Name.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BookShelf_MouseDoubleClick);
            this.Lab_Name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BookShelf_MouseDown);
            this.Lab_Name.MouseEnter += new System.EventHandler(this.BookShelf_MouseEnter);
            this.Lab_Name.MouseLeave += new System.EventHandler(this.BookShelf_MouseLeave);
            this.Lab_Name.MouseHover += new System.EventHandler(this.BookShelf_MouseHover);
            // 
            // PbxPoster
            // 
            this.PbxPoster.Image = ((System.Drawing.Image)(resources.GetObject("PbxPoster.Image")));
            this.PbxPoster.Location = new System.Drawing.Point(0, 0);
            this.PbxPoster.Name = "PbxPoster";
            this.PbxPoster.Size = new System.Drawing.Size(120, 150);
            this.PbxPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPoster.TabIndex = 1;
            this.PbxPoster.TabStop = false;
            this.PbxPoster.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BookShelf_MouseDoubleClick);
            this.PbxPoster.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BookShelf_MouseDown);
            this.PbxPoster.MouseEnter += new System.EventHandler(this.BookShelf_MouseEnter);
            this.PbxPoster.MouseLeave += new System.EventHandler(this.BookShelf_MouseLeave);
            this.PbxPoster.MouseHover += new System.EventHandler(this.BookShelf_MouseHover);
            // 
            // BookShelf
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.PbxPoster);
            this.Controls.Add(this.Lab_Name);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(11, 5, 11, 3);
            this.Name = "BookShelf";
            this.Size = new System.Drawing.Size(120, 190);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BookShelf_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BookShelf_MouseDown);
            this.MouseEnter += new System.EventHandler(this.BookShelf_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.BookShelf_MouseLeave);
            this.MouseHover += new System.EventHandler(this.BookShelf_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.PbxPoster)).EndInit();
            this.ResumeLayout(false);

        }

        private void BookShelf_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{
                _isSelect = true;
                ShowTextBackColor = Color.Goldenrod;
                ShowTextColor = Color.White;
            //}
        }

        private void BookShelf_MouseEnter(object sender, EventArgs e)
        {
            _isSelect = true;
            ShowTextBackColor = Color.Goldenrod;
            ShowTextColor = Color.White;
        }

        private void BookShelf_MouseHover(object sender, EventArgs e)
        {
            _isSelect = true;
            ShowTextBackColor = Color.Goldenrod;
            ShowTextColor = Color.White;
        }

        private void BookShelf_MouseLeave(object sender, EventArgs e)
        {
            Rectangle rc = this.RectangleToScreen(this.ClientRectangle);
            if (rc.Contains(MousePosition))
            {
                return;
            }
            _isSelect = false;
            ShowTextBackColor = Color.Transparent;
            ShowTextColor = Color.Black;
        }

        /// <summary>
        /// 双击控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookShelf_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(Item_Double_Click!=null&&Tag!=null)
                Item_Double_Click(this.Tag,e);
        }

        //添加鼠标移动事件，鼠标离开范围时，撤销选择！！！！！！！


        #region 事件
        [Browsable(true), Description("书籍双击事件")]
        public event EventHandler Item_Double_Click;
        #endregion


    }
}
