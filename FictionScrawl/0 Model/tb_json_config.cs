using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FictionScrawl._0_Model
{
    [DataContract]
    public class tb_json_config
    {
        /// <summary>
        /// 缓存章节数
        /// </summary>
        [DataMember]
        public int _i_Cache_Chapter { get; set; }

        /// <summary>
        /// 缓存整本
        /// </summary>
        [DataMember]
        public bool _b_Cache_All { get; set; }

        /// <summary>
        /// 书架缓存目录
        /// </summary>  
        [DataMember]
        public string _s_Bookshelf_Dir { get; set; }

        /// <summary>
        /// 下载队列大小
        /// </summary>
        [DataMember]
        public int _i_Download_Queue { get; set; }

        /// <summary>
        /// 下载最大线程数
        /// </summary>
        [DataMember]
        public int _i_Download_Max_Thread { get; set; }

        /// <summary>
        /// 下载目录
        /// </summary>
        [DataMember]
        public string _s_Download_Dir { set; get; }

        /// <summary>
        /// 开机自启
        /// </summary>
        [DataMember]
        public bool _b_Autu_Start { get; set; }


        /// <summary>
        /// 数据库连接语句
        /// </summary>
        [DataMember]
        public string _s_MySQL_Con { get; set; }
    }
}
