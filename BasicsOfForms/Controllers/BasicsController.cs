using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace BasicsOfForms.Controllers
{
    public class BasicsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            var i = 0;
            return View();
        }
        public ActionResult Razor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Razor(FormCollection form)
        {
            var i = 0;
            return View();
        }
        public ActionResult Angular()
        {
            return View();
        }
    }
}