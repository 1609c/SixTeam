namespace BW.DirSir.Model.Commoditys
{
    /// <summary>
    /// 商品表
    /// </summary>
   public class Commodity
    {
        public int Id { get; set; }

        /// <summary>
        /// 商品货号
        /// </summary>
        public string ArtNo { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string CommodityName { get; set; }

        /// <summary>
        /// 商品颜色
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Num { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Prices { get; set; }

        /// <summary>
        /// 类别ID
        /// </summary>
        public int CategoryId { get; set; }
    }
}
