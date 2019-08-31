using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FictionScrawl._0_Model
{
    [DataContract]
    public class tb_json_bookshelf
    {
        /// <summary>
        /// 书架列表
        /// </summary>
        [DataMember]
        public List<tb_json_fiction_info> _ltjfi_Bookshelf { get; set; }


    }
}
