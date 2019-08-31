using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Update_Soft.Model
{
    public class File_Info
    {
        /// <summary>
        /// 文件名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 文件大小
        /// </summary>
        public double Size { get; set; }
        /// <summary>
        /// 文件创建日期
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// 文件创建时间
        /// </summary>
        public string Time { get; set; }
    }
}
