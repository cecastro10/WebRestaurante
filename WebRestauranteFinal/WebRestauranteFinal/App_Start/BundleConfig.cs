using System.Web;
using System.Web.Optimization;

namespace WebRestauranteFinal
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.validate.unobtrusive.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                "~/Scripts/angular.js",
                "~/Scripts/angular-sanitize.min.js",
                "~/Scripts/i18n/angular-locale_pt-br.js"));

            bundles.Add(new ScriptBundle("~/bundles/ctrl").Include(
                "~/Scripts/ctrl/App.js",
               "~/Scripts/ctrl/RestauranteCtrl.js",
                "~/Scripts/ctrl/PratoCtrl.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                    "~/Scripts/bootstrap.js",
                    "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/ng-table").Include(
                      "~/Scripts/ng-table.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/ng-table.min.css",
                        "~/Content/ace.min.css",
                        "~/Content/font-awesome.min.css",
                      "~/Content/site.css"));
        }
    }
}
