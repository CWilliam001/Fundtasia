using System.Web;
using System.Web.Optimization;

namespace Fundtasia
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
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/Scripts/jquery.js",
                      "~/Scripts/popper.min.js",
                      "~/Scripts/jquery.appear.min.js",
                      "~/Scripts/jquery.jCounter.js",
                      "~/Scripts/jquery.magnific-popup.min.js",
                      "~/Scripts/owl.carousel.min.js",
                      "~/Scripts/wow.min.js",
                      "~/Scripts/isotope.pkgd.min.js",
                      "~/Scripts/main.js"));

            bundles.Add(new ScriptBundle("~/bundles/adminJs").Include(
                      "~/Content/plugins/bower_components/jquery/dist/jquery.min.js",
                      "~/Scripts/app-style-switcher.js",
                      "~/Content/plugins/bower_components/jquery-sparkline/jquery.sparkline.min.js",
                      "~/Scripts/waves.js",
                      "~/Scripts/sidebarmenu.js",
                      "~/Scripts/custom.js",
                      "~/Content/plugins/bower_components/chartist/dist/chartist.min.js",
                      "~/Content/plugins/bower_components/chartist-plugin-tooltips/dist/chartist-plugin-tooltip.min.js",
                      "~/Scripts/pages/dashboards/dashboard1.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/style.css",
                      "~/Content/animate.css",
                      "~/Content/font-awesome.css",
                      "~/Content/magnific-popup.css",
                      "~/Content/owl.carousel.min.css",
                      "~/Content/isotop.css",
                      "~/Content/xsIcon.css",
                      "~/Content/responsive.css",
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/admin").Include(
                      "~/Content/style-admin.css",
                      "~/Content/plugins/bower_components/chartist/dist/chartist.min.css",
                      "~/Content/plugins/bower_components/chartist-plugin-tooltips/dist/chartist-plugin-tooltip.css",
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
