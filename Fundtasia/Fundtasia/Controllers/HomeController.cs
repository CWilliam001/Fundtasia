using System;
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
    }
}