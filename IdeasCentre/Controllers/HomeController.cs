﻿using System;
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Upload your filoes";

            return View();
        }
    }
}