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
        HttpClientHelper client = new HttpClientHelper("http://localhost:64774/");
        public ActionResult Index()
        {
            var user = client.Get("api/Default/GetClassList");
            var list = JsonConvert.DeserializeObject<List<Class>>(user);
            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}