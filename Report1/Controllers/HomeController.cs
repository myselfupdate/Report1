using Report1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Report1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DBModel1 bModel1 = new DBModel1();
            var result = from p in bModel1.dataTables select p;
            TempData["testdata"] = result;
            return View();
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