using System;
using System.Web.Optimization;

namespace MVC5_Practice
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                 "~/Content/themes/base/jquery.ui.core.css",
                 "~/Content/themes/base/jquery.ui.resizable.css",
                 "~/Content/themes/base/jquery.ui.selectable.css",
                 "~/Content/themes/base/jquery.ui.accordion.css"));
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundle/jqruryui").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/jquery.unobtrusive*"));
        }
    }
}