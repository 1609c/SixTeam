using BW.DirSir.IRepository;
using BW.DirSir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Unity;

namespace BW.DirSir.OJOApi.Controllers
{
    public class DefaultController : ApiController
    {
        [Dependency]
        public IClassRepository ClassRepository { get; set; }

        [HttpGet]
        public List<Class> GetClassList()
        {
            var result = ClassRepository.GetClassList();
            return result;
        }
    }
}
