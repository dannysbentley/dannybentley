using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dannybentley.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RevitAPI()
        {
            return View();
        }

        public ActionResult DynamoBIM()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Little bit about me.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}