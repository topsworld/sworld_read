using FictionScrawl._0_Model;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FictionScrawl._4_ScrawlCore._0_BQG
{
    public class Cls_Fiction_Search
    {
        const string _url_Search = "https://sou.xanbhx.com/search?siteid=qula&q=";
        string _str_KeyWord = "";
        public Cls_Fiction_Search() { }
        public Cls_Fiction_Search(string _keyword)
        {
            _str_KeyWord = _keyword;
        }

        /// <summary>
        /// 根据关键词获取小说列表
        /// </summary>
        /// <returns></returns>
        public List<tb_fiction_info> _o_Get_Fiction_Info_By_KeyWord()
        {
            //判断关键字
            if (_str_KeyWord == "")
                return null;

            List<tb_fiction_info> _ltfi_ret = new List<tb_fiction_info>();

            HtmlWeb _web_Main = new HtmlWeb();
            _web_Main.OverrideEncoding = Encoding.UTF8;
            try
            {
                HtmlAgilityPack.HtmlDocument _doc_Main = new HtmlAgilityPack.HtmlDocument();
                _doc_Main = _web_Main.Load(_url_Search + _str_KeyWord);
                //判断是否有数据
                if (_doc_Main.Text == "")
                    return null;

                //获取查询列表
                HtmlNodeCollection _hnc_Search_List = _doc_Main.DocumentNode.SelectNodes("//div[starts-with(@class,'search-list')]/ul/li");
                //查询列表第一项为表头，所有查询项数据需要大于1
                if (_hnc_Search_List.Count == 1)
                    return null;
                //移除表头
                _hnc_Search_List.RemoveAt(0);

                foreach (HtmlNode _hn in _hnc_Search_List)
                {
                    HtmlAgilityPack.HtmlDocument _doc_One = new HtmlAgilityPack.HtmlDocument();
                    _doc_One.LoadHtml(_hn.InnerHtml);
                    tb_fiction_info _tfi = new tb_fiction_info();
                    //获取小说类型
                    HtmlNodeCollection _hnc_Fiction_Type = _doc_One.DocumentNode.SelectNodes("//span[starts-with(@class,'s1')]");
                    if (_hnc_Fiction_Type != null && _hnc_Fiction_Type.Count > 0)
                    {
                        _tfi.col_fiction_type = _hnc_Fiction_Type[0].InnerText.Replace("[", "").Replace("]", "");
                    }
                    //获取小说名称及主页链接
                    HtmlNodeCollection _hnc_Fiction_Name_URL = _doc_One.DocumentNode.SelectNodes("//span[starts-with(@class,'s2')]/a");
                    if (_hnc_Fiction_Name_URL != null && _hnc_Fiction_Name_URL.Count > 0)
                    {
                        _tfi.col_fiction_name = _hnc_Fiction_Name_URL[0].InnerText.Trim();
                        _tfi.col_url_homepage = _hnc_Fiction_Name_URL[0].Attributes["href"].Value;
                    }
                    //获取最新章节及链接
                    HtmlNodeCollection _hnc_Update_Chapter_URL = _doc_One.DocumentNode.SelectNodes("//span[starts-with(@class,'s3')]/a");
                    if (_hnc_Update_Chapter_URL != null && _hnc_Update_Chapter_URL.Count > 0)
                    {
                        _tfi.col_update_chapter = _hnc_Update_Chapter_URL[0].InnerText;
                        _tfi.col_update_chapter_url = _hnc_Update_Chapter_URL[0].Attributes["href"].Value;
                    }
                    //获取小说作者
                    HtmlNodeCollection _hnc_Fiction_Author = _doc_One.DocumentNode.SelectNodes("//span[starts-with(@class,'s4')]");
                    if (_hnc_Fiction_Author != null && _hnc_Fiction_Author.Count > 0)
                    {
                        _tfi.col_fiction_author = _hnc_Fiction_Author[0].InnerText;
                    }
                    //获取点击数
                    HtmlNodeCollection _hnc_Click_Count = _doc_One.DocumentNode.SelectNodes("//span[starts-with(@class,'s5')]");
                    if (_hnc_Click_Count != null && _hnc_Click_Count.Count > 0)
                    {
                        _tfi.col_click_count = _hnc_Click_Count[0].InnerText;
                    }
                    //获取更新时间
                    HtmlNodeCollection _hnc_Update_Time = _doc_One.DocumentNode.SelectNodes("//span[starts-with(@class,'s6')]");
                    if (_hnc_Update_Time != null && _hnc_Update_Time.Count > 0)
                    {
                        _tfi.col_update_time = DateTime.Parse(_hnc_Update_Time[0].InnerText);
                    }
                    //获取小说状态
                    HtmlNodeCollection _hnc_Fiction_Stata = _doc_One.DocumentNode.SelectNodes("//span[starts-with(@class,'s7')]");
                    if (_hnc_Fiction_Stata != null && _hnc_Fiction_Stata.Count > 0)
                    {
                        _tfi.col_fiction_stata = _hnc_Fiction_Stata[0].InnerText;
                    }
                    _tfi.col_fiction_source = "笔趣阁";

                    _ltfi_ret.Add(_tfi);
                }
                return _ltfi_ret;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 根据关键词获取小说列表
        /// </summary>
        /// <param name="_s_kw">关键词</param>
        /// <returns></returns>
        public List<tb_fiction_info> _o_Get_Fiction_Info_By_KeyWord(string _s_kw)
        {
            _str_KeyWord = _s_kw;
            return _o_Get_Fiction_Info_By_KeyWord();
        }

        /// <summary>
        /// 获取小说信息，包括章节，封皮
        /// </summary>
        /// <param name="_tfi"></param>
        /// <returns></returns>
        public tb_fiction_detail_info _o_Get_Fiction_All_Info(tb_fiction_info _tfi)
        {
            if (_tfi == null)
                return null;

            tb_fiction_detail_info _tfdi = new tb_fiction_detail_info();
            _tfdi._tfi_Fiction = new tb_fiction_info();
            _tfdi._ltcl_Chapter = new List<tb_chapter_list>();


            HtmlWeb _web_Main = new HtmlWeb();
            _web_Main.OverrideEncoding = Encoding.UTF8;
            try
            {
                HtmlAgilityPack.HtmlDocument _doc_Main = new HtmlAgilityPack.HtmlDocument();
                _doc_Main = _web_Main.Load(_tfi.col_url_homepage);
                //判断是否有数据
                if (_doc_Main.Text == "")
                    return null;

                //获取小说名
                _tfdi._tfi_Fiction.col_fiction_name = _tfi.col_fiction_name;
                //小说主页链接
                _tfdi._tfi_Fiction.col_url_homepage = _tfi.col_url_homepage;

                //获取小说信息
                HtmlNodeCollection _hnc_Info = _doc_Main.DocumentNode.SelectNodes("//div[starts-with(@id,'maininfo')]/div[starts-with(@id,'info')]");
                if (_hnc_Info.Count == 0)
                    return null;

                //获取小说作者
                _tfdi._tfi_Fiction.col_fiction_author = _tfi.col_fiction_author;

                //获取最后更新时间
                _tfdi._tfi_Fiction.col_update_time = _tfi.col_update_time;

                //获取最后更新章节及链接
                _tfdi._tfi_Fiction.col_update_chapter = _tfi.col_update_chapter;
                _tfdi._tfi_Fiction.col_update_chapter_url = _tfi.col_update_chapter_url;

                //获取小说简介
                HtmlNodeCollection _hnc_Intro = _doc_Main.DocumentNode.SelectNodes("//div[starts-with(@id,'maininfo')]/div[starts-with(@id,'intro')]");
                if (_hnc_Intro.Count > 0)
                {
                    _tfdi._tfi_Fiction.col_fiction_introduction = _hnc_Intro[0].InnerText.Trim();
                }

                //小说封皮链接
                HtmlNodeCollection _hnc_Poster_URL = _doc_Main.DocumentNode.SelectNodes("//div[starts-with(@id,'sidebar')]/div/img");
                if (_hnc_Poster_URL.Count > 0)
                {
                    _tfdi._tfi_Fiction.col_url_poster = "https://www.qu.la" + _hnc_Poster_URL[0].Attributes["src"].Value;
                }


                //设置来源
                _tfdi._tfi_Fiction.col_fiction_source = "笔趣阁";

                //获取点击量
                _tfdi._tfi_Fiction.col_click_count = _tfi.col_click_count;

                //获取状态
                _tfdi._tfi_Fiction.col_fiction_stata = _tfi.col_fiction_stata;

                //小说类型
                _tfdi._tfi_Fiction.col_fiction_type = _tfi.col_fiction_type;


                //获取章节列表
                HtmlNodeCollection _hnc_Chapter_List = _doc_Main.DocumentNode.SelectNodes("//div[starts-with(@id,'list')]/dl/dd/a");
                if (_hnc_Chapter_List.Count != 0)
                {
                    foreach (HtmlNode _hn in _hnc_Chapter_List)
                    {
                        tb_chapter_list _tcl_one = new tb_chapter_list();
                        _tcl_one.col_fiction_id = _tfi.col_fiction_id;
                        _tcl_one.col_volume_id = 0;
                        _tcl_one.col_chapter_name = _hn.InnerText;
                        _tcl_one.col_chapter_url = _tfi.col_url_homepage + _hn.Attributes["href"].Value;
                        _tfdi._ltcl_Chapter.Add(_tcl_one);
                    }
                }

                //获取小说封皮
                //链接有误
                if (_tfdi._tfi_Fiction.col_url_poster != "")
                {
                    _tfdi._img_Poster = Image.FromStream(WebRequest.Create(_tfdi._tfi_Fiction.col_url_poster)
                        .GetResponse().GetResponseStream());
                }


                return _tfdi;
            }
            catch {
                return null;
            }
        }
    }

}
