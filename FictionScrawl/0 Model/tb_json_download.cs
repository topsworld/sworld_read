using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FictionScrawl._0_Model
{
    [DataContract]
    public class tb_json_download
    {
        /// <summary>
        /// 列表
        /// </summary>
        [DataMember]
        public List<tb_json_fiction_info> _ltjfi_Download { get; set; }

        ///// <summary>
        ///// 下载完成列表
        ///// </summary>
        //[DataMember]
        //public List<tb_json_fiction_info> _ltjfi_UnDownload { get; set; }
    }
}
