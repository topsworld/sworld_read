using FictionScrawl._0_Model;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FictionScrawl._4_ScrawlCore._0_BQG
{
    public class Cls_Get_Chapter_Content
    {
        string _url_Chapter = "";
        int _i_Percent = 0;
        tb_fiction_info _tfi_Main;
        List<tb_chapter_list> _ltcl_ALL;
        List<Task> _ltask=new List<Task>();

        /// <summary>
        /// 设置小说实体
        /// </summary>
        public tb_fiction_info Tfi_Main { get => _tfi_Main; set => _tfi_Main = value; }

        /// <summary>
        /// 实例化爬取章节内容
        /// </summary>
        public Cls_Get_Chapter_Content(tb_fiction_info _tfi=null)
        {
            _tfi_Main = _tfi;
        }
        /// <summary>
        /// 实例化爬取章节内容
        /// </summary>
        /// <param name="_url">章节URL</param>
        public Cls_Get_Chapter_Content(string _url, tb_fiction_info _tfi = null)
        {
            _url_Chapter = _url;
            _tfi_Main = _tfi;
        }
        /// <summary>
        /// 获取单章节内容
        /// </summary>
        /// <returns>章节内容</returns>
        public string Get_Chapter_Content()
        {
            string _s_ret = "";
            //判断链接是否存在
            if (_url_Chapter == "")
                return _s_ret;

            HtmlWeb _web_Main = new HtmlWeb();
            _web_Main.OverrideEncoding = Encoding.UTF8;
            try
            {
                HtmlAgilityPack.HtmlDocument _doc_Main = new HtmlAgilityPack.HtmlDocument();
                _doc_Main = _web_Main.Load(_url_Chapter);
                //判断是否有数据
                if (_doc_Main.Text == "")
                    return _s_ret;

                //获取章节内容
                HtmlNodeCollection _hnc_Chapter_Content = _doc_Main.DocumentNode
                    .SelectNodes("//div[starts-with(@class,'content_read')]/div[starts-with(@class,'box_con')]/div[starts-with(@id,'content')]");
                if (_hnc_Chapter_Content.Count == 0)
                    return _s_ret;

                _s_ret = _hnc_Chapter_Content[0].InnerHtml.Trim()
                    .Replace("&nbsp;", " ")
                    .Replace("<br>", "\r\n")
                    .Replace("</br>", "\r\n")
                    .Replace("nbsp;", "")
                    .Replace("&amp;", "")
                    .Replace("<script>chaptererror();</script>", "");

                _s_ret = _2_BLL.Cls_Oprt_String._s_Merge_Space(_s_ret, "\r\n    ");

                return _s_ret;
            }
            catch
            {
                return "";
            }
        }
        /// <summary>
        /// 获取单章节内容
        /// </summary>
        /// <param name="_url">章节URL</param>
        /// <returns>章节内容</returns>
        public string Get_Chapter_Content(string _url)
        {
            _url_Chapter = _url;
            return Get_Chapter_Content();
        }

        /// <summary>
        /// 根据tb_chapter_list实体获取章节内容
        /// </summary>
        /// <param name="_tcl"></param>
        public void Get_One_Chapter_Content(tb_chapter_list _tcl)
        {
            if (_tcl == null || _tcl.IsDownload == false)//当章节没有下载时，需要下载章节内容
            {
                _tcl.col_chapter_content = Get_Chapter_Content(_tcl.col_chapter_url);
                _tcl.IsDownload = true;
            }
        }

        /// <summary>
        /// 多任务下载章节列表
        /// </summary>
        /// <param name="_ltcl"></param>
        public void Get_All_Chapter_Content(List<tb_chapter_list> _ltcl)
        {
            _ltcl_ALL = _ltcl;
            _ltask.Clear();
            //任务添加
            foreach (tb_chapter_list _tcl in _ltcl_ALL)
            {
                Task _task = new Task(()=> 
                {
                    Get_One_Chapter_Content(_tcl);
                });
                _ltask.Add(_task);
            }

            _ltask.ForEach(a => a.Start());

            Thread _th_Monitor = new Thread(_Thread_Monitor);
            _th_Monitor.Start();
            //Task.WaitAll(_ltask.ToArray());
            
            //return _ltcl_ALL;
        }

        /// <summary>
        /// 委托事件
        /// </summary>
        public event _Delegate_CallBack Event_Delegate;

        /// <summary>
        /// 监控线程
        /// </summary>
        /// <param name="_o"></param>
        private void _Thread_Monitor(object _o)
        {
            while (true)
            {
                if (_ltask.TrueForAll(a => a.IsCompleted == true))
                {
                    _i_Percent = 100;
                    Event_Delegate(_i_Percent, _ltcl_ALL,this);
                    break;
                }
                else
                {
                    _i_Percent = _ltask.Where(a => a.IsCompleted == true).Count() * 100 / _ltask.Count();
                    Event_Delegate(_i_Percent,null,this);
                    Thread.Sleep(500);
                }
            }
        }

        public void Stop()
        {
            //_ltask.ForEach(a=>a.)
        }

        /// <summary>
        /// 存储内容
        /// </summary>
        /// <param name="_name">文件名</param>
        /// <param name="_path">文件路径</param>
        /// <returns></returns>
        public bool _b_Save_Content(string _name,string _path)
        {
            try
            {
                if (_i_Percent != 100)
                    return false;
                using (StreamWriter sw = new StreamWriter(Path.Combine(_path, _name)))
                {
                    //写入小说名
                    if (_tfi_Main == null)
                        sw.WriteLine(_name);
                    else
                        sw.WriteLine(_tfi_Main.col_fiction_name + "\r\n\r\n");
                    foreach (tb_chapter_list _tcl in _ltcl_ALL)
                    {
                        sw.WriteLine(_tcl.col_chapter_name);
                        sw.WriteLine(_tcl.col_chapter_content);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 委托
        /// </summary>
        /// <param name="_i_scale">下载百分比 0-100</param>
        /// <param name="_ltcl_ret">章节内容列表</param>
        public delegate void _Delegate_CallBack(int _i_scale,List<tb_chapter_list> _ltcl_ret=null, Cls_Get_Chapter_Content _cgcc = null);
    }
    
}
