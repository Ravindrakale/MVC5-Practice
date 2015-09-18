using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5_Practice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Customer()
        {
            return View("View");
        }
	}
}