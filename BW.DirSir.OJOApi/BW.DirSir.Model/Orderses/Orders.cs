using System;

namespace BW.DirSir.Model.Orderses
{
    /// <summary>
    /// 订单表
    /// </summary>
    public class Orders
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        public DateTime OrderTime { get; set; }

        /// <summary>
        /// 收货人ID
        /// </summary>
        public int ConsigneeId { get; set; }

        /// <summary>
        /// 付款方式
        /// </summary>
        public int Payment { get; set; }

        /// <summary>
        /// 付款状态
        /// </summary>
        public int PaymentStatus { get; set; }

        /// <summary>
        /// 配送状态
        /// </summary>
        public int ShipmentStatus { get; set; }

        /// <summary>
        /// 送货日期
        /// </summary>
        public DateTime DeliveryTime { get; set; }
        /// <summary>
        /// 商品ID
        /// </summary>
        public int CommodityId { get; set; }

        /// <summary>
        /// 验光ID
        /// </summary>
        public int OptometryId { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        public decimal SumPrice { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UsersId { get; set; }
    }
}
