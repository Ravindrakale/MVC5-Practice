using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace MVC5_Practice.Utility
{
    public static class CutomHelper
    {
        public static MvcHtmlString SubmmiteButton(this HtmlHelper helper, string buttonText)
        {
            string str = "<input type=\"submit\" value=\"" + buttonText + "\" />";
            return new MvcHtmlString(str);
        }

        public static MvcHtmlString TextBoxFor<TModel, TValue>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TValue>> expression, bool isReadonly)
        {
            MvcHtmlString html = default(MvcHtmlString);
            if (isReadonly)
            {
                html = System.Web.Mvc.Html.InputExtensions.TextBoxFor(htmlHelper,
                expression, new
                {
                    @class = "readOnly",
                    @readonly = "read-only"
                });
            }
            else
            {
                html = System.Web.Mvc.Html.InputExtensions.TextBoxFor(htmlHelper, expression);
            }
            return html;
        }
    }
}