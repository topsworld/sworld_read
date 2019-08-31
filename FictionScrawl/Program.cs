using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FictionScrawl
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new _5_Demo.Frm_Demo_Main());
            //Application.Run(new _5_Demo.Frm_Demo_Get_Fiction_Info());
            //Application.Run(new _5_Demo.Frm_Demo_Get_Chapter_List());
            //Application.Run(new Frm_Demo_Get_Fiction_Poster());
            Directory.CreateDirectory(Environment.CurrentDirectory+"//Bookshelf//Poster");
            Directory.CreateDirectory(Environment.CurrentDirectory+ "//Download//Poster");
            Application.Run(new Frm_Main());
        }
    }
}
