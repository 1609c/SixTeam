using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BW.DirSir.Model.Refractivitys
{
    /// <summary>
    /// 镜片折射率
    /// </summary>
    public class Refractivity
    {

        /// <summary>
        /// 主键Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 镜片折射率
        /// </summary>
        public decimal Number { get; set; }
    }
}
