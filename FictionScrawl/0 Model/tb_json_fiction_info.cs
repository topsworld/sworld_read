using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FictionScrawl._0_Model
{
    /// <summary>
    /// 继承于小说信息，增加小说存放路径和
    /// </summary>
    public class tb_json_fiction_info: tb_fiction_info
    {
        /// <summary>
        /// 存放文件名
        /// </summary>
        public string col_file_name { get; set; }
        /// <summary>
        /// 存放路径
        /// </summary>
        public string col_fiction_path { get; set; }
        /// <summary>
        /// 封皮存放路径
        /// </summary>
        public string col_poster_path { get; set; }
        /// <summary>
        /// 索引
        /// </summary>
        public int _i_Index { get; set; }
        /// <summary>
        /// 下载进度
        /// </summary>
        public int _i_Download_Percent { get; set; }

        private bool _b_IsDownload = false;
        /// <summary>
        /// 是否下载完成
        /// </summary>
        public bool B_IsDownload { get => _b_IsDownload; set => _b_IsDownload = value; }

    }
}
