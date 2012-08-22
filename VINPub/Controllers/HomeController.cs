using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VINPub.Infrastructure.Logging;

namespace VINPub.Controllers
{
    public class HomeController : Controller
    {
        INlogger _logger;
        public HomeController(INlogger logger )
        {
            _logger = logger;
        }
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
