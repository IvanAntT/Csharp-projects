using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_MVC_posledno_.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int numTimes)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.Num = numTimes;

            return View();
        }
    }
}
