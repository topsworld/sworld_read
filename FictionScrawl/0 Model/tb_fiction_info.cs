using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FictionScrawl._0_Model
{
    /// <summary>
    /// 小说信息实体
    /// </summary>
    [Table("tb_fiction_info")]
    public class tb_fiction_info
    {
        /// <summary>
        /// 小说ID
        /// </summary>
        [Column("col_fiction_id", IsPrimaryKey = true)]
        public int col_fiction_id { get; set; }
        /// <summary>
        /// 小说名
        /// </summary>
        public string col_fiction_name { get; set; }
        /// <summary>
        /// 小说作者
        /// </summary>
        public string col_fiction_author { get; set; }
        /// <summary>
        /// 小说类型
        /// </summary>
        public string col_fiction_type { get; set; }
        /// <summary>
        /// 小说点击数
        /// </summary>
        public string col_click_count { get; set; }
        /// <summary>
        /// 小说状态
        /// </summary>
        public string col_fiction_stata { get; set; }
        /// <summary>
        /// 小说最后更新时间
        /// </summary>
        public DateTime col_update_time { get; set; }
        /// <summary>
        /// 小说最后更新章节
        /// </summary>
        public string col_update_chapter { get; set; }
        /// <summary>
        /// 小说最后更新章节URL
        /// </summary>
        public string col_update_chapter_url { get; set; }
        /// <summary>
        /// 小说简介
        /// </summary>
        public string col_fiction_introduction { get; set; }
        /// <summary>
        /// 小说封皮URL
        /// </summary>
        public string col_url_poster { get; set; }
        /// <summary>
        /// 小说主页URL
        /// </summary>
        public string col_url_homepage { get; set; }
        /// <summary>
        /// 小说来源
        /// </summary>
        public string col_fiction_source { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string col_remark { get; set; }
    }
}
