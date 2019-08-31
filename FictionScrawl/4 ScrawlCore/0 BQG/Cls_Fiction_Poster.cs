using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FictionScrawl._4_ScrawlCore._0_BQG
{
    public class Cls_Fiction_Poster
    {
        string _url_Poster = "";
        /// <summary>
        /// 实例化获取小说封皮
        /// </summary>
        public Cls_Fiction_Poster() { }
        /// <summary>
        /// 实例化获取小说封皮
        /// </summary>
        /// <param name="_s_URL">封皮链接</param>
        public Cls_Fiction_Poster(string _s_URL)
        {
            _url_Poster = _s_URL;
        }

        /// <summary>
        /// 获取小说封皮
        /// </summary>
        /// <param name="_path">存储路径</param>
        /// <returns></returns>
        public bool _b_Get_Fiction_Poster(string _path)
        {
            try
            {
                //链接有误
                if (_url_Poster == "")
                    return false;
                WebClient _wc_Get = new WebClient();
                _wc_Get.DownloadFile(_url_Poster, _path);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 获取小说封皮
        /// </summary>
        /// <param name="_path">存储路径</param>
        /// <param name="_url">封皮链接</param>
        /// <returns></returns>
        public bool _b_Get_Fiction_Poster(string _path, string _url)
        {
            _url_Poster = _url;
            return _b_Get_Fiction_Poster(_path);
        }

        /// <summary>
        /// 获取小说封皮
        /// </summary>
        /// <returns>Image</returns>
        public Image _img_Get_Fiction_Poster_Image()
        {
            try
            {
                //链接有误
                if (_url_Poster == "")
                    return null;
                return Image.FromStream(WebRequest.Create(_url_Poster).GetResponse().GetResponseStream()); 
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 获取小说封皮
        /// </summary>
        /// <param name="_url">封皮链接</param>
        /// <returns>Image</returns>
        public Image _img_Get_Fiction_Poster_Image(string _url)
        {
            _url_Poster = _url;
            return _img_Get_Fiction_Poster_Image();
        }

    }
}
