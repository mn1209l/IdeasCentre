using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdeasCentre.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Share your Ideas";

            return View();
        }

        public ActionResult About2()
        {
            ViewBag.Message = "Share your Ideas";

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Show your files";

            return View();
        }
        public ActionResult Contact2()
        {
            ViewBag.Message = "Show your filoes";

            return View();
        }
    }
}
