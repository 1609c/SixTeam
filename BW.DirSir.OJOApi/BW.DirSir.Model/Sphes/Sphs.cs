namespace BW.DirSir.Model.Sphes
{

    /// <summary>
    /// 关系表
    /// </summary>
  public class Sph2
    {
        public int Id { get; set; }

        /// <summary>
        /// 镜片折射率ID
        /// </summary>
        public int RefractivityId { get; set; }

        /// <summary>
        /// 适用人群ID
        /// </summary>
        public int CrowdId { get; set; }

        /// <summary>
        /// 材质ID
        /// </summary>
        public int TextureId { get; set; }

        /// <summary>
        /// 类型ID
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// 边框ID
        /// </summary>
        public int BorderId { get; set; }

        /// <summary>
        /// 框型Id
        /// </summary>
        public int CribId { get; set; }

        /// <summary>
        /// 品牌Id
        /// </summary>
        public int BrandId { get; set; }

        /// <summary>
        /// 价格ID
        /// </summary>
        public int PriceID { get; set; }

        /// <summary>
        /// 图片Id
        /// </summary>
        public int PictureID { get; set; }

        /// <summary>
        /// 功能Id
        /// </summary>
        public int FunctionalId { get; set; }

        /// <summary>
        /// 适合度数Id
        /// </summary>
        public int SuitId { get; set; }

        /// <summary>
        /// 类别Id
        /// </summary>
        public int CategoryId { get; set; }

    }
}
