using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Pract_9.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Test1()
        {
            ViewBag.Message = "Hello World!";
            return View();
        }

        public ActionResult Test2()
        {
            

            return View();
        }

        public ActionResult Test3()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}