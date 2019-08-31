using FictionScrawl._0_Model;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FictionScrawl._4_ScrawlCore._0_BQG
{
    public class Cls_Get_Chapter_List
    {
        string _url_Homepage = "";
        tb_fiction_info _tfi_Main;
        public Cls_Get_Chapter_List() { }
        public Cls_Get_Chapter_List(string _url)
        {
            _url_Homepage = _url;
        }
        public Cls_Get_Chapter_List(tb_fiction_info _tfi)
        {
            _tfi_Main = _tfi;
            _url_Homepage = _tfi.col_url_homepage;
        }


        public List<tb_chapter_list> _b_Get_Chapter_List()
        {
            //判断链接是否存在
            if (_tfi_Main==null|| _url_Homepage == "")
                return null;

            List<tb_chapter_list> _ltcl_ret = new List<tb_chapter_list>();

            HtmlWeb _web_Main = new HtmlWeb();
            _web_Main.OverrideEncoding = Encoding.UTF8;
            try
            {
                HtmlAgilityPack.HtmlDocument _doc_Main = new HtmlAgilityPack.HtmlDocument();
                _doc_Main = _web_Main.Load(_url_Homepage);
                //判断是否有数据
                if (_doc_Main.Text == "")
                    return null;

                //获取章节列表
                HtmlNodeCollection _hnc_Chapter_List = _doc_Main.DocumentNode.SelectNodes("//div[starts-with(@id,'list')]/dl/dd/a");
                if (_hnc_Chapter_List.Count == 0)
                    return null;
                foreach (HtmlNode _hn in _hnc_Chapter_List)
                {
                    tb_chapter_list _tcl_one = new tb_chapter_list();
                    _tcl_one.col_fiction_id = _tfi_Main.col_fiction_id;
                    _tcl_one.col_volume_id = 0;
                    _tcl_one.col_chapter_name = _hn.InnerText;
                    _tcl_one.col_chapter_url =_tfi_Main.col_url_homepage+ _hn.Attributes["href"].Value;
                    _ltcl_ret.Add(_tcl_one);
                }
            }
            catch
            {
                return null;
            }

            return _ltcl_ret;
        }

        public List<tb_chapter_list> _b_Get_Chapter_List(string _url)
        {
            _url_Homepage = _url;
            return _b_Get_Chapter_List();
        }

        public List<tb_chapter_list> _b_Get_Chapter_List(tb_fiction_info _tfi)
        {
            _tfi_Main = _tfi;
            _url_Homepage = _tfi.col_url_homepage;
            return _b_Get_Chapter_List();
        }
    }
}
