using BW.DirSir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BW.DirSir.IRepository
{
    public interface IClassRepository
    {
        List<Class> GetClassList();
    }
}
