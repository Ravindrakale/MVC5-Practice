using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5_Practice.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index(int? id)
        {
            return View("View");
        }

        public ActionResult ViewResult()
        {
            return View("Index");
        }
	}
}