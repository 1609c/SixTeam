using BW.DirSir.Model.Dto;
using BW.DirSir.Model.Orderses;

namespace BW.DirSir.IRepository
{
    public interface IOrderRepository
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        int Add(Orders orders);

        ///// <summary>
        ///// 查询
        ///// </summary>
        ///// <param name="name"></param>
        ///// <param name="pageIndex"></param>
        ///// <param name="pageSize"></param>
        ///// <returns></returns>
        //OrdersDto GetOrdersDto(string name="", int pageIndex=1, int pageSize=2); 
    }
}
