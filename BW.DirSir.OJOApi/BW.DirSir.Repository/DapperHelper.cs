using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BW.DirSir.Repository
{
    public class DapperHelper
    {
        public static string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        public static SqlConnection conn = null;
        /// <summary>
        /// 获取连接数据库的字符串
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnString()
        {
            if (conn == null)
            {
                return new SqlConnection(connString);
            }
            return conn;
        }

        ///// <summary>
        ///// 公共分页方法
        ///// </summary>
        ///// <typeparam name="T">表名</typeparam>
        ///// <param name="criteria">分页对象</param>
        ///// <returns></returns>
        //public static PageDataView<T> GetPageData<T>(PageCriteria criteria)
        //{
        //    using (SqlConnection conn = GetConnString())
        //    {
        //        conn.Open();

        //        DynamicParameters parms = new DynamicParameters();
        //        //数据库存储过程的变量 
        //        //表头
        //        parms.Add("@TableName", criteria.TableName, DbType.String, ParameterDirection.Input, null);
        //        //表中的主键
        //        parms.Add("@PrimaryKey", criteria.PrimaryKey, DbType.String, ParameterDirection.Input, null);
        //        //读取数据库中字段
        //        parms.Add("@Fields", criteria.Fields, DbType.String, ParameterDirection.Input, null);
        //        //where条件
        //        parms.Add("@Condition", criteria.Condition, DbType.String, ParameterDirection.Input, null);
        //        //当前页
        //        parms.Add("@CurrentPage", criteria.PageIndex, DbType.Int32, ParameterDirection.Input, null);
        //        //页大小
        //        parms.Add("@PageSize", criteria.PageSize, DbType.Int32, ParameterDirection.Input, null);
        //        //排序的字段
        //        parms.Add("@Sort", criteria.Sort, DbType.String, ParameterDirection.Input, null);
        //        //输出参数总页数
        //        parms.Add("@RecordCount", criteria.RecordCount, DbType.Int32, ParameterDirection.Output, null);
                
        //        //定义变量 数据库中分页存储过程的名称
        //        string proName = "p_getpage";
        //        var pageData = new PageDataView<T>();
        //        pageData.PersonList = conn.Query<T>(proName, parms, null, true, null, CommandType.StoredProcedure).ToList();
        //        conn.Close();
        //        pageData.Total = parms.Get<int>("RecordCount");
        //        pageData.PageSize = Convert.ToInt32(Math.Ceiling(pageData.Total * 1.0 / criteria.PageSize));
        //        pageData.PageIndex = criteria.PageIndex > pageData.PageSize ? pageData.PageSize : criteria.PageIndex;
        //        return pageData;
        //    }
        //}
    }
}
