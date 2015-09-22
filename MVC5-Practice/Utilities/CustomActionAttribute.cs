using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5_Practice.Utilities
{
    public class CustomActionAttribute : FilterAttribute, IActionFilter
    {
        void IActionFilter.OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.Controller.ViewBag.OnActionExecuted = "IActionFilter.OnActionExecuted filter called";
        }

        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                //filterContext.Result = new RedirectResult("/AboutUs");
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}