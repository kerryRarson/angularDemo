using System.Web;
using System.Web.Optimization;

namespace AngularDemo
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/AngularDemo")
                .IncludeDirectory("~/Scripts/Controllers", "*.js")
                .IncludeDirectory("~/Scripts/Factories", "*.js")
                .Include("~/Scripts/AngularDemo.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
