namespace BW.DirSir.Model.Pictures
{
    /// <summary>
    /// 图片表
    /// </summary>
   public class Picture
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int  Id { get; set; }

        /// <summary>
        /// 图片路径
        /// </summary>
        public string PictureUrl { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public int CommodityId { get; set; }
    }
}
