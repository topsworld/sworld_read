using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FictionScrawl._2_BLL
{
    public class Cls_Oprt_String
    {
        /// <summary>
        /// 字符串中多个连续空格转为一个空格
        /// </summary>
        /// <param name="str">待处理的字符串</param>
        /// <returns>合并空格后的字符串</returns>
        public static string _s_Merge_Space(string _str,string _str_replace)
        {
            if (_str != string.Empty &&
                _str != null &&
                _str.Length > 0
                )
            {
                _str = new System.Text.RegularExpressions.Regex("[\\s]+").Replace(_str, _str_replace) ;
            }
            return _str;
        }
    }
}
