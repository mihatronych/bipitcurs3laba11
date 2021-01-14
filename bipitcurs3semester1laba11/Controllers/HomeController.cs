using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bipitcurs3semester1laba11.Models;
namespace bipitcurs3semester1laba11.Controllers
{
    public class HomeController : Controller
    {
        Journal journal = new Journal();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Books()
        {
            ViewBag.Message = "Книги";

            return View();
        }

        public ActionResult Readers()
        {
            ViewBag.Message = "Читатели";

            return View();
        }
    }
}
