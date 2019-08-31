using Chloe.MySql;
using FictionScrawl._0_Model;
using FictionScrawl._1_DAL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FictionScrawl._1_DAL
{
    public class Cls_Chapter_List
    {
        /// <summary>
        /// 添加单章节至数据库
        /// </summary>
        /// <param name="_tcl">数据</param>
        /// <returns></returns>
        public static bool _b_Insert_Chapter_List(tb_chapter_list _tcl)
        {
            try
            {
                Cls_MySQLHelper<tb_chapter_list> _msh = new Cls_MySQLHelper<tb_chapter_list>();
                MySqlContext context = _msh.DbContext();
                context.Insert(_tcl);
                _msh.Dispose_Db();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        /// <summary>
        /// 添加多章节至数据库
        /// </summary>
        /// <param name="_ltcl">多条数据</param>
        /// <returns></returns>
        public static bool _b_Insert_Chapter_List(List<tb_chapter_list> _ltcl)
        {
            try
            {
                Cls_MySQLHelper<tb_chapter_list> _msh = new Cls_MySQLHelper<tb_chapter_list>();
                MySqlContext context = _msh.DbContext();
                context.InsertRange(_ltcl);
                _msh.Dispose_Db();
                return true;
            }
            catch 
            {
                return false;
            }
        }


        /// <summary>
        /// 根据小说ID获取小说章节列表
        /// </summary>
        /// <param name="_id">小说ID</param>
        /// <returns></returns>
        public static List<tb_chapter_list> _o_Get_Chapter_List_By_Fiction_ID(int _id)
        {
            try
            {
                Cls_MySQLHelper<tb_chapter_list> _mtd = new Cls_MySQLHelper<tb_chapter_list>();
                MySqlContext context = _mtd.DbContext();
                //建立连接
                List<tb_chapter_list> _ltcl_ret = context.Query<tb_chapter_list>()
                    .Where(a=>a.col_fiction_id==_id).ToList();
                _mtd.Dispose_Db();
                return _ltcl_ret;
            }
            catch
            {
                return null;
            }
        }

    }
}
