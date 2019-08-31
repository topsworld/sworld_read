using FictionScrawl._0_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FictionScrawl._4_ScrawlCore._0_BQG
{
    public class Cls_Fiction_Download
    {
        //最大线程数量
        int _i_Max_Thread = 20;
        //线程，章节  List
        List<(Thread, int[])> _lthread;

        //小说详细信息实体
        tb_fiction_detail_info _tfdi_Main;
        public tb_fiction_detail_info Tfdi_Main { get => _tfdi_Main; set => _tfdi_Main = value; }

        //实例化章节获取函数
        Cls_Get_Chapter_Content _cgcc = new Cls_Get_Chapter_Content();

        //小说章节数
        int _i_chapter_count = 0;
        //每个线程下载章节数量
        int _i_one_thread_chapter_count = 0;
        //下载完成章节数
        int _i_download_chapter_finish_count = 0;

        ListViewItem _lvi_Download;
        /// <summary>
        /// 设置绑定的ListviewItems
        /// </summary>
        public ListViewItem Lvi_Download { get => _lvi_Download; set => _lvi_Download = value; }

        bool _b_Stop = false;
        /// <summary>
        /// true：停止  false：继续
        /// </summary>
        public bool B_Stop { get => _b_Stop; set => _b_Stop = value; }


        public Cls_Fiction_Download(tb_fiction_detail_info _tfdi,ListViewItem _lvi)
        {
            _lthread = new List<(Thread, int[])>();
            Tfdi_Main = _tfdi;
            Lvi_Download = _lvi;
            //判断是否为空
            if (Tfdi_Main == null)
                throw new Exception("小说实体信息为空");
            //获取小说章节数
            _i_chapter_count = Tfdi_Main._ltcl_Chapter.Count;
            //获取每个线程下载章节数量
            _i_one_thread_chapter_count = _i_chapter_count / _i_Max_Thread;
            //前n-1个线程，获取整除后的章节数
            for (int i = 0; i < _i_Max_Thread - 1; i++)
            {
                Thread _th = new Thread(_thread_One);
                _th.IsBackground = true;
                _th.Name = i.ToString();
                _lthread.Add((_th,
                    new int[] { i * _i_one_thread_chapter_count, (i + 1) * _i_one_thread_chapter_count }));
            }
            //第n个线程需要获取后续所有章节内容
            Thread _th_Last = new Thread(_thread_One);
            _th_Last.IsBackground = true;
            _th_Last.Name = (_i_Max_Thread - 1).ToString();
            _lthread.Add((_th_Last,
                new int[] { (_i_Max_Thread - 1) * _i_one_thread_chapter_count, _i_chapter_count }));

        }



        /// <summary>
        /// 开始任务
        /// </summary>
        public void Start()
        {
            _lthread.ForEach(a => a.Item1.Start(a.Item2));
        }

        /// <summary>
        /// 暂停任务
        /// </summary>
        public void Stop()
        {
            //_lthread.ForEach(a => a.Item1.Suspend());
            _b_Stop = true;
            _Download_CallBack?.Invoke(Tfdi_Main, Lvi_Download);
        }

        /// <summary>
        /// 恢复任务
        /// </summary>
        public void Continue()
        {
            _b_Stop = false;
            _Download_CallBack?.Invoke(Tfdi_Main, Lvi_Download);
        }

        /// <summary>
        /// 取消任务
        /// </summary>
        public void Cancel()
        {
            _b_Stop = false;
            _lthread.ForEach(a => a.Item1.Abort()) ;
            _lthread.ForEach(a => a.Item1.Join());
            _Download_CallBack?.Invoke(null, Lvi_Download);
        }

        bool _pre_stop = false;
        /// <summary>
        /// 单个线程任务
        /// </summary>
        /// <param name="_o">章节实体</param>
        public void _thread_One(object _o)
        {
            try
            {
                int[] _range = _o as int[];
                for (int i = _range[0]; i < _range[1]; i++)
                {
                    if (_pre_stop != _b_Stop)//状态改变
                    {
                        _lvi_Download.ListView.BeginInvoke(new Action(() =>
                        {
                            if (_b_Stop)
                            {
                                _lvi_Download.SubItems[3].Text = "暂停下载";
                            }
                            else
                            {
                                _lvi_Download.SubItems[3].Text = "正在下载";
                                //判断进度是否为
                            }
                        }));
                        _pre_stop = _b_Stop;
                    }
                    while (_b_Stop) { Thread.Sleep(100); };//是否停止

                    _cgcc.Get_One_Chapter_Content(Tfdi_Main._ltcl_Chapter[i]);
                    _i_download_chapter_finish_count += 1;
                    //当进度发生变化时，才需要触发事件，防止反复触发浪费资源
                    int _ls_percent = _i_download_chapter_finish_count * 100 / _i_chapter_count;
                    if ((_ls_percent != Tfdi_Main._i_Download_Percent && _b_Stop == false) || _ls_percent == 100)//进度变化，且不停止下载 | 或者下载完成 触发事件
                    {
                        Tfdi_Main._i_Download_Percent = _ls_percent;
                        _Download_CallBack?.Invoke(Tfdi_Main, Lvi_Download);
                    }

                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// 委托事件
        /// </summary>
        public event _Delegate_Download_CallBack _Download_CallBack;

    }

    public delegate void _Delegate_Download_CallBack(tb_fiction_detail_info _tfdi,ListViewItem _lvi );
}
