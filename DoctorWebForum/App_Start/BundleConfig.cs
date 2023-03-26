using System.Web;
using System.Web.Optimization;

namespace DoctorWebForum
{
    public class BundleConfig
    {
        //Used for bundling to reduce request loadtime
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Bundle for javascript and jquery files
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                       "~/Scripts/jquery-{version}.js",
                       "~/Scripts/bootstrap.js",
                        "~/Scripts/bootbox.js",
                        "~/Scripts/DataTables/jquery.datatables.js",
                        "~/Scripts/DataTables/jquery.datatables.bootstrap.js",
                        "~/Scripts/typeahead.bundle.js",
                        "~/Scripts/toastr.js",
                        "~/Scripts/sweetalert.js",
                        "~/Scripts/nicepage.js"));

            //Bundle for jquery validation
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //Bundle for the general css files
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css",
                      "~/Content/bootstrap-lumen.css",
                      "~/Content/bootstrap-theme.css",
                      "~/Content/DataTables/css/datatables.jqueryui.css",
                      "~/Content/typeahead.css",
                      "~/Content/toastr.css",
                      "~/Content/nicepage.css",
                      "~/Content/fontAwesome/css/all.css",
                      "~/Content/style.css"
                      ));

            //Bundle for home page css file
            bundles.Add(new StyleBundle("~/Content/css/Home").Include(
                     "~/Content/home.css"
                     ));

            //Bundle for Login page css file
            bundles.Add(new StyleBundle("~/Content/css/Login").Include(
                     "~/Content/Login.css"
                     ));

            //Bundle for registration and edit page css file
            bundles.Add(new StyleBundle("~/Content/css/GeneralForm").Include(
                     "~/Content/general-form.css"
                     ));

            //Bundle for user profile page css file
            bundles.Add(new StyleBundle("~/Content/css/User").Include(
                     "~/Content/User.css"
                     ));

            //Bundle for Members page css file
            bundles.Add(new StyleBundle("~/Content/css/Members").Include(
                     "~/Content/MembersList.css"
                     ));

            //Bundle for 404 page css file
            bundles.Add(new StyleBundle("~/Content/css/Error").Include(
                     "~/Content/404.css"
                     ));
        }
    }
}
