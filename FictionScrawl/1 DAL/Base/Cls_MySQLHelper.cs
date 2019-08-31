using Chloe;
using Chloe.MySql;
using System.Collections.Generic;
using System.Linq;

namespace FictionScrawl._1_DAL.Base
{
    /// <summary>
    /// MySQL数据库操作类
    /// </summary>
    public class Cls_MySQLHelper<T>
    {
        private string Str_Con;
        private MySqlContext _DbContext;
        public Cls_MySQLHelper()
        {
            Str_Con = _2_BLL.Cls_Oprt_Config.Str_Con();//获取连接字符串 
            _DbContext = new MySqlContext(new Cls_MySqlConnectionFactory(Str_Con));
        }

        /// <summary>
        /// 运用事务检查sql语句是否正确
        /// </summary>
        /// <param name="_s_sql"></param>
        /// <returns></returns>
        public bool b_Check_SQL(string _s_sql)
        {
            using (_DbContext)
            {
                try
                {
                    _DbContext.Session.BeginTransaction();//开始事务

                    /* do some things here */
                    _DbContext.SqlQuery<T>(_s_sql).ToList();

                    _DbContext.Session.RollbackTransaction();//回滚
                    return true;
                }
                catch
                {
                    if (_DbContext.Session.IsInTransaction)//回滚
                        _DbContext.Session.RollbackTransaction();
                    return false;
                }
            }
        }

        /// <summary>
        /// 获取数据库DbContext
        /// </summary>
        /// <returns></returns>
        public MySqlContext DbContext()
        {
            return _DbContext;
        }
        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose_Db()
        {
            _DbContext.Dispose();
        }
        /// <summary>
        /// 获取IQuery
        /// </summary>
        /// <returns></returns>
        public IQuery<T> Get_IQuery()
        {
            return _DbContext.Query<T>();
        }
        /// <summary>
        /// 获取全部数据
        /// </summary>
        /// <returns></returns>
        public List<T> Get_ALL()
        {
            IQuery<T> q = _DbContext.Query<T>();
            List<T> LT = q.ToList();
            return LT;
        }

        /// <summary>
        /// 获取记录条数
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            IQuery<T> q = _DbContext.Query<T>();
            return q.Count();
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="LT_IN">待处理数据</param>
        /// <returns></returns>
        public int Insert(T LT_IN)
        {
            try
            {
                _DbContext.Insert(LT_IN);
            }
            catch
            {
                throw;
            }
            return 0;
        }
        /// <summary>
        /// 批量插入数据
        /// </summary>
        /// <param name="LT_IN">待处理数据</param>
        /// <returns></returns>
        public int Insert(List<T> LT_IN)
        {
            int i_ret = 0;
            if (LT_IN.Count > 0)
            {
                foreach (T LT in LT_IN)
                    i_ret = Insert(LT);
            }
            return i_ret;
        }
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="LT_IN">待处理数据</param>
        /// <returns></returns>
        public int Update(T LT_IN)
        {
            return _DbContext.Update(LT_IN);
        }
        /// <summary>
        /// 批量更新数据
        /// </summary>
        /// <param name="LT_IN">待处理数据</param>
        /// <returns></returns>
        public int Update(List<T> LT_IN)
        {
            int i_ret = 0;
            if (LT_IN.Count > 0)
            {
                foreach (T LT in LT_IN)
                    i_ret = Update(LT);
            }
            return i_ret;
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="LT_IN">待处理数据</param>
        /// <returns></returns>
        public int Delete(T LT_IN)
        {
            return _DbContext.Delete(LT_IN);
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        /// <param name="LT_IN">待处理数据</param>
        /// <returns></returns>
        public int Delete(List<T> LT_IN)
        {
            int i_ret = 0;
            if (LT_IN.Count > 0)
            {
                foreach (T LT in LT_IN)
                    i_ret = Delete(LT);
            }
            return i_ret;
        }
    }
}
