using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BW.DirSir.OJOMVC.Models;
using Newtonsoft.Json;

namespace BW.DirSir.OJOMVC.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
    }
}