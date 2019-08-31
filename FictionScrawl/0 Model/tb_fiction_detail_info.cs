using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FictionScrawl._0_Model
{
    [DataContract]
    public class tb_fiction_detail_info
    {
        /// <summary>
        /// 小说信息
        /// </summary>
        [DataMember]
        public tb_fiction_info _tfi_Fiction { get; set; }
        /// <summary>
        /// 小说章节
        /// </summary>
        [DataMember]
        public List<tb_chapter_list> _ltcl_Chapter { get; set; }
        /// <summary>
        /// 小说封皮
        /// </summary>
        [DataMember]
        public Image _img_Poster { get; set; }
        /// <summary>
        /// 小说封皮路径
        /// </summary>
        [DataMember]
        public string _s_Poster { get; set; }
        /// <summary>
        /// 阅读章节索引
        /// </summary>
        [DataMember]
        public int _i_Index { get; set; }
        /// <summary>
        /// 小说实体文件存放路径
        /// </summary>
        [DataMember]
        public string _s_File_Path { get; set; }


        /// <summary>
        /// 下载进度
        /// </summary>
        [DataMember]
        public int _i_Download_Percent { get; set; }

        private bool _b_IsDownload = false;
        /// <summary>
        /// 是否下载完成
        /// </summary>
        [DataMember]
        public bool B_IsDownload { get => _b_IsDownload; set => _b_IsDownload = value; }
    }
}
