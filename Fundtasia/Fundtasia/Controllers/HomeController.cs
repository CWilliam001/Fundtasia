﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fundtasia.Controllers
{
    public class HomeController : Controller
    {
        // GET: https://localhost:44384/Home/Index
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult LogIn()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

        public ActionResult Event()
        {
            return View();
        }

        public ActionResult Donation()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }
    }
}