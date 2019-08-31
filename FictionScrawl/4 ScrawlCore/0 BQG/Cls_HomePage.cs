using FictionScrawl._0_Model;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FictionScrawl._4_ScrawlCore._0_BQG
{
    public class Cls_HomePage
    {
        string _url_Homepage = "";

        public Cls_HomePage(){}
        public Cls_HomePage(string _url)
        {
            _url_Homepage = _url;
        }

        public tb_fiction_info _o_Get_Fiction_Info()
        {
            //判断链接是否存在
            if (_url_Homepage == "")
                return null;

            tb_fiction_info _tfi_ret = new tb_fiction_info();

            HtmlWeb _web_Main = new HtmlWeb();
            _web_Main.OverrideEncoding = Encoding.UTF8;
            try
            {
                HtmlAgilityPack.HtmlDocument _doc_Main = new HtmlAgilityPack.HtmlDocument();
                _doc_Main = _web_Main.Load(_url_Homepage);
                //判断是否有数据
                if (_doc_Main.Text=="")
                    return null;

                //获取小说名
                HtmlNodeCollection _hnc_Title = _doc_Main.DocumentNode.SelectNodes("//div[starts-with(@id,'maininfo')]/div/h1");
                if (_hnc_Title.Count == 0)
                    return null;
                _tfi_ret.col_fiction_name = _hnc_Title[0].InnerText;
                //小说主页链接
                _tfi_ret.col_url_homepage = _url_Homepage;

                //获取小说信息
                HtmlNodeCollection _hnc_Info= _doc_Main.DocumentNode.SelectNodes("//div[starts-with(@id,'maininfo')]/div[starts-with(@id,'info')]");
                if (_hnc_Info.Count == 0)
                    return null;

                //获取小说作者
                var _rg_Author = Regex.Matches(_hnc_Info[0].InnerHtml.Replace("&nbsp;",""), @">作者：([^<]+)<");
                if (_rg_Author.Count > 0)
                {
                    _tfi_ret.col_fiction_author = _rg_Author[0].Value.Replace(">作者：", "")
                        .Replace("<", "");
                }

                //获取最后更新时间
                var _rg_Update_Time = Regex.Matches(_hnc_Info[0].InnerText, @"最后更新：(\d{4})/(\d{1,2})/(\d{1,2}) (\d{1,2}):(\d{1,2}):(\d{1,2})");
                if (_rg_Update_Time.Count > 0)
                {
                    _tfi_ret.col_update_time = DateTime.Parse(_rg_Update_Time[0].Value.Substring(5));
                }
                else
                {
                    _rg_Update_Time = Regex.Matches(_hnc_Info[0].InnerText, @"最后更新：(\d{1,2})/(\d{1,2})/(\d{4}) (\d{1,2}):(\d{1,2}):(\d{1,2})");
                    if (_rg_Update_Time.Count > 0)
                    {
                        string[] _ls_Time = _rg_Update_Time[0].Value.Substring(5).Split(' ');
                        string[] _ls_Time1=_ls_Time[0].Split('/');
                        string _s_Full_Time = _ls_Time1[2] + "/" + _ls_Time1[0] + '/' + _ls_Time1[1] + " "
                            + _ls_Time[1];
                        _tfi_ret.col_update_time = DateTime.Parse(_s_Full_Time);
                    }
                }

                //获取最后更新章节及链接
                HtmlNodeCollection _hnc_Chapter = _doc_Main.DocumentNode.SelectNodes("//div[starts-with(@id,'maininfo')]/div/p");
                List<HtmlNode> _lhn_Chapter= _hnc_Chapter.Where(a => a.InnerText.Contains("最新更新")).ToList();
                if (_lhn_Chapter.Count > 0)
                {
                    //最新章节名
                    _tfi_ret.col_update_chapter = _lhn_Chapter[0].InnerText.Split('：')[1];
                    //最新章节链接
                    var _rg_Chapter_URL = Regex.Matches(_lhn_Chapter[0].InnerHtml.Replace("&nbsp;", ""), "href=\"([^\"]+)\"");
                    if (_rg_Chapter_URL.Count > 0)
                    {
                        _tfi_ret.col_update_chapter_url =_url_Homepage+ _rg_Chapter_URL[0].Value.Replace("href=\"", "")
                            .Replace("\"", "");
                    }
                }

                //获取小说简介
                HtmlNodeCollection _hnc_Intro = _doc_Main.DocumentNode.SelectNodes("//div[starts-with(@id,'maininfo')]/div[starts-with(@id,'intro')]");
                if (_hnc_Intro.Count > 0)
                {
                    _tfi_ret.col_fiction_introduction = _hnc_Intro[0].InnerText.Trim();
                }

                //小说封皮链接
                HtmlNodeCollection _hnc_Poster_URL = _doc_Main.DocumentNode.SelectNodes("//div[starts-with(@id,'sidebar')]/div/img");
                if (_hnc_Poster_URL.Count > 0)
                {
                    _tfi_ret.col_url_poster = "https://www.qu.la" + _hnc_Poster_URL[0].Attributes["src"].Value;
                }


                //设置来源
                _tfi_ret.col_fiction_source = "笔趣阁";

            }
            catch
            {
                return null;
            }

            return _tfi_ret;
        }

        public tb_fiction_info _o_Get_Fiction_Info(string _url)
        {
            _url_Homepage = _url;
            return _o_Get_Fiction_Info();
        }
    }
}
