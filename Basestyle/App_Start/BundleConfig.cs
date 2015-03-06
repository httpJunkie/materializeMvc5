using System.Web;
using System.Web.Optimization;

namespace Basestyle
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/materializeJs").Include(
                      "~/Scripts/materialize/materialize.js",
                      //"~/Scripts/materialize/animation.js",
                      //"~/Scripts/materialize/buttons.js",
                      //"~/Scripts/materialize/cards.js",
                      //"~/Scripts/materialize/collapsible.js",
                      //"~/Scripts/materialize/dropdown.js",
                      //"~/Scripts/materialize/forms.js",
                      //"~/Scripts/materialize/leanModal.js",
                      //"~/Scripts/materialize/materialbox.js",
                      //"~/Scripts/materialize/parallax.js",
                      //"~/Scripts/materialize/pushpin.js",
                      //"~/Scripts/materialize/scrollFire.js",
                      //"~/Scripts/materialize/scrollspy.js",
                      //"~/Scripts/materialize/sideNav.js",
                      //"~/Scripts/materialize/slider.js",
                      //"~/Scripts/materialize/tabs.js",
                      //"~/Scripts/materialize/toasts.js",
                      //"~/Scripts/materialize/tooltip.js",
                      //"~/Scripts/materialize/transitions.js",
                      //"~/Scripts/materialize/waves.js",
                      "~/Scripts/materialize/init.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/angular.js",
                        //"~/Scripts/angular-cookies.js",
                        //"~/Scripts/angular-animate",
                        //"~/Scripts/angular-aria",
                        //"~/Scripts/angular-loader.js",
                        //"~/Scripts/angular-messages.js",
                        //"~/Scripts/angular-mocks.js",
                        //"~/Scripts/angular-resource.js",
                        //"~/Scripts/angular-sanitize.js",
                        //"~/Scripts/angular-touch.js",
                        "~/Scripts/angular-route.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/materialize/sass/materialize.css",
                      "~/Content/style.css"));
        }
    }
}
