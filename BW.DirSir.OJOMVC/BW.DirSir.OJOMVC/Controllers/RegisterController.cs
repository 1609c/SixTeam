using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BW.DirSir.OJOMVC.Controllers
{
    public class RegisterController : Controller
    {
        /// <summary>
        /// 注册
        /// </summary>
        /// <returns></returns>
        public ActionResult RegisterIndex()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}