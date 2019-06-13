using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BW.DirSir.Model.Orderses;

namespace BW.DirSir.Model.Dto
{
   public class OrdersDto
    {
        public List<Orders> OrdersList { get; set; }
        public int Total { get; set; }
    }
}
