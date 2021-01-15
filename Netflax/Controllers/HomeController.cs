using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Netflax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Home = "active";
            return View();
        }

        public ActionResult Videos()
        {
            ViewBag.Videos = "active";
            return View();
        }

        public ActionResult Reviews()
        {
            ViewBag.Reviews = "active";
            return View();
        }
        public ActionResult Page404()
        {
            ViewBag.Page404 = "active";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Contact = "active";
            return View();
        }
    }
}