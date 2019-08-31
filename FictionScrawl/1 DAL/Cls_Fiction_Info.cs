using Chloe.MySql;
using FictionScrawl._0_Model;
using FictionScrawl._1_DAL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FictionScrawl._1_DAL
{
    public class Cls_Fiction_Info
    {
        /// <summary>
        /// 添加单本小说至数据库
        /// </summary>
        /// <param name="_tfi">数据</param>
        /// <returns></returns>
        public static bool _b_Insert_Fiction_Info(tb_fiction_info _tfi)
        {
            try
            {
                Cls_MySQLHelper<tb_fiction_info> _msh = new Cls_MySQLHelper<tb_fiction_info>();
                MySqlContext context = _msh.DbContext();
                context.Insert(_tfi);
                _msh.Dispose_Db();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 批量添加至数据库
        /// </summary>
        /// <param name="_ltfi">数据</param>
        /// <returns></returns>
        public static bool _b_Insert_Fiction_Info(List<tb_fiction_info> _ltfi)
        {
            try
            {
                Cls_MySQLHelper<tb_fiction_info> _msh = new Cls_MySQLHelper<tb_fiction_info>();
                MySqlContext context = _msh.DbContext();
                context.InsertRange(_ltfi);
                _msh.Dispose_Db();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 更新单本小说至数据库
        /// </summary>
        /// <param name="_tfi">数据</param>
        /// <returns></returns>
        public static bool _b_Update_Fiction_Info(tb_fiction_info _tfi)
        {
            try
            {
                Cls_MySQLHelper<tb_fiction_info> _msh = new Cls_MySQLHelper<tb_fiction_info>();
                MySqlContext context = _msh.DbContext();
                context.Update(_tfi);
                _msh.Dispose_Db();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 更新多本小说至数据库
        /// </summary>
        /// <param name="_tfi">数据</param>
        /// <returns></returns>
        public static bool _b_Update_Fiction_Info(List<tb_fiction_info> _ltfi)
        {
            try
            {
                Cls_MySQLHelper<tb_fiction_info> _msh = new Cls_MySQLHelper<tb_fiction_info>();
                MySqlContext context = _msh.DbContext();
                context.Update(_ltfi);
                _msh.Dispose_Db();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 根据查询条件获取小说列表
        /// </summary>
        /// <param name="_s_Query">查询条件</param>
        /// <returns></returns>
        public static List<tb_fiction_info> _o_Get_Fiction_List_By_Query(string _s_Query)
        {
            try
            {
                string _str_factor = string.Format("select * from tb_fiction_info {0}", _s_Query);
                Cls_MySQLHelper<tb_fiction_info> _mtd = new Cls_MySQLHelper<tb_fiction_info>();
                MySqlContext context = _mtd.DbContext();
                //建立连接
                List<tb_fiction_info> _ltfi_ret = context.SqlQuery<tb_fiction_info>(_str_factor).ToList();
                _mtd.Dispose_Db();
                return _ltfi_ret;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 根据查询条件分页查询
        /// </summary>
        /// <param name="_i_ref_count">数据条数</param>
        /// <param name="str_fct">查询条件</param>
        /// <param name="i_now">页码</param>
        /// <param name="i_one">范围</param>
        /// <returns></returns>
        public static List<tb_fiction_info> _o_Get_Fiction_List_By_Query(out int _i_ref_count, string str_fct = "", int i_now = 1, int i_one = 20)
        {
            try
            {
                string _str_factor = string.Format("select * from tb_fiction_info {0} limit {1},{2}", str_fct, (i_now - 1) * i_one, i_one);
                Cls_MySQLHelper<tb_fiction_info> _mtd = new Cls_MySQLHelper<tb_fiction_info>();
                MySqlContext context = _mtd.DbContext();
                //建立连接
                List<tb_fiction_info> _ltfi_ret = context.SqlQuery<tb_fiction_info>(_str_factor).ToList();//获取列表
                _i_ref_count = context.SqlQuery<tb_fiction_info>(string.Format("select * from tb_fiction_info {0}", str_fct)).Count();//获取数据条数
                _mtd.Dispose_Db();
                return _ltfi_ret;
            }
            catch
            {
                _i_ref_count = 0;
                return null;
            }
        }


    }
}
