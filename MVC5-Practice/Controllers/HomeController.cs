using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5_Practice.Models;

namespace MVC5_Practice.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index(string id)
        {
            int m = Convert.ToInt32(id);
            Registration reg = new Registration();
            reg.Gender = 1;
            reg.Name = "Ravindra Kale";
            reg.IsMarried = true;
            return View(reg);
        }

        [HttpPost]
        public ActionResult Index(MVC5_Practice.Models.Registration Reg)
        {
            if (ModelState.IsValid)
            {
                ModelState.AddModelError("", "This is Model Level Error");
                ModelState.AddModelError("Name", "This is Model Level Error");
            }
            //return View();
            //return RedirectToAction("Page404");
            //return Redirect("Home/Page404");
            return RedirectToRoute("ravi");
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