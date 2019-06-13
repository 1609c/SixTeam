using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BW.DirSir.IRepository;
using BW.DirSir.Model.Dto;
using BW.DirSir.Model.Orderses;
using Dapper;

namespace BW.DirSir.Repository
{
    public class OrderRepository : IOrderRepository
    {
        //链接
        public static string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        public int Add(Orders orders)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string strSql =
                    $"insert into Orders (OrderNumber,OrderTime,ConsigneeId,Payment,PaymentStatus,ShipmentStatus,DeliveryTime,CommodityId,OptometryId,SumPrice,UsersId) values('{orders.OrderNumber}','{orders.OrderTime}','{orders.ConsigneeId}','{orders.Payment}','{orders.PaymentStatus}','{orders.ShipmentStatus}','{orders.DeliveryTime}','{orders.CommodityId}','{orders.OptometryId}','{orders.SumPrice}','{orders.UsersId}')";
                int p = conn.Execute(strSql, null);
                return p;

            }
        }
    }
}

///// <summary>
        ///// 查询分页
        ///// </summary>
        ///// <param name="name"></param>
        ///// <param name="pageIndex"></param>
        ///// <param name="pageSize"></param>
        ///// <returns></returns>
        //public OrdersDto GetOrdersDto(string name="", int pageIndex=1, int pageSize=2)
        //{
        //    OrdersDto ordersDto=new OrdersDto();
        //    using (SqlConnection conn = new SqlConnection(connString))
        //    {
        //        StringBuilder str=new StringBuilder("select * from Orders where 1=1 ");
        //        StringBuilder strcount=new StringBuilder("select count(*) from orders where 1=1");
        //        if (!string.IsNullOrWhiteSpace(name))
        //        {
        //            str.Append($" and OrderNumber like'%{name}%'");
        //            strcount.Append($"and OrderNumber like'%{name}%' ");
        //        }

        //        str.Append($" order by Id offset ({pageIndex - 1}*{pageSize})  rows fetch next ({pageSize}) rows only");


        //  }
       // }
    

