using Microsoft.Owin;
using Owin;
using TodoModule.Web.App.Startup;
using System.Web.Optimization;

namespace TodoModule.Web.App.Startup
{
    public static class AppBundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //APPLICATION

            bundles.Add(
                new StyleBundle("~/Embedded/App/css")
                    .Include("~/App/todo.css")
                );


            bundles.Add(
                new ScriptBundle("~/Embedded/App/js")
                    .Include("~/App/todo.js")
                );
        }
    }
}
