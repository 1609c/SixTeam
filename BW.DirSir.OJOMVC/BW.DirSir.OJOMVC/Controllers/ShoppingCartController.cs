using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BW.DirSir.OJOMVC.Controllers
{
    public class ShoppingCartController : Controller
    {
        /// <summary>
        /// 购物车
        /// </summary>
        /// <returns></returns>
        public ActionResult ShoppingCartIndex()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}