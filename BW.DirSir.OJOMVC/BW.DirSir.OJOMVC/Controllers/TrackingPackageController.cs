using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BW.DirSir.OJOMVC.Controllers
{
    public class TrackingPackageController : Controller
    {
        /// <summary>
        /// 跟踪包裹
        /// </summary>
        /// <returns></returns>
        public ActionResult TrackingPackageIndex()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}