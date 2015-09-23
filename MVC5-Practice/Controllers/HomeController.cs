using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5_Practice.Models;
using System.Web.SessionState;

namespace MVC5_Practice.Controllers
{
    [SessionState(SessionStateBehavior.Disabled)]
    public class HomeController : Controller
    {
        public ActionResult Index(int? id)
        {
            return View("AboutUs");
        }

        [HttpPost]
        public ActionResult Index(MVC5_Practice.Models.Registration Reg)
        {
            if (ModelState.IsValid)
            {
                if (Request.IsAjaxRequest())
                {
                    return PartialView("_Home", Reg);
                }
                View(Reg);
            }
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult Page404()
        {
            return View();
        }
    }
}