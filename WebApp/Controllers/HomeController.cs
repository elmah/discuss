using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    [HandleError(View = "Error")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // https://groups.google.com/d/msg/elmah/6baNilOnWyk/tPl8rprXBgAJ

        public ActionResult Error() => throw new HttpException(message: "Testing ELMAH");
    }
}