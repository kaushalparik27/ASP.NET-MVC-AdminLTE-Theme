using System.Web;
using System.Web.Optimization;

namespace TemplateAdminLTE
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/AdminLTE/bower_components/bootstrap/dist/css/bootstrap.min.css",
                      "~/Content/site.css",
                      "~/AdminLTE/dist/css/AdminLTE.min.css",
                      "~/AdminLTE/dist/css/skins/skin-blue.css",
                      "~/AdminLTE/bower_components/font-awesome/css/font-awesome.min.css",
                      "~/AdminLTE/bower_components/Ionicons/css/ionicons.min.css",
                      "~/AdminLTE/bower_components/jvectormap/jquery-jvectormap.css"));

            bundles.Add(new ScriptBundle("~/bundles/adminltejs").Include(
                      "~/AdminLTE/dist/js/adminlte.min.js",
                      "~/AdminLTE/bower_components/fastclick/lib/fastclick.js",
                      "~/AdminLTE/bower_components/jquery-sparkline/dist/jquery.sparkline.min.js",
                      "~/AdminLTE/bower_components/jquery-slimscroll/jquery.slimscroll.min.js"));
        }
    }
}
