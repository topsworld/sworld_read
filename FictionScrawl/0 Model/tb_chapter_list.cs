using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FictionScrawl._0_Model
{

    [Table("tb_chapter_list")]
    public class tb_chapter_list
    {
        /// <summary>
        /// 章节ID
        /// </summary>
        [Column("col_chapter_id", IsPrimaryKey = true)]
        public int col_chapter_id { get; set; }
        /// <summary>
        /// 小说ID
        /// </summary>
        public int col_fiction_id { get; set; }
        /// <summary>
        /// 卷ID
        /// </summary>
        public int col_volume_id { get; set; }
        /// <summary>
        /// 章节名
        /// </summary>
        public string col_chapter_name { get; set; }
        /// <summary>
        /// 章节URL
        /// </summary>
        public string col_chapter_url { get; set; }
        /// <summary>
        /// 章节内容
        /// </summary>
        public string col_chapter_content { get; set; }
        
        /// <summary>
        /// 是否下载标识
        /// </summary>

        bool isDownload = false;

        public bool IsDownload { get => isDownload; set => isDownload = value; }

    }
}
