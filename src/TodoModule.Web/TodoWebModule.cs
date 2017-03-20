using System.Reflection;
using Abp.Modules;
using Abp.Resources.Embedded;
using TodoModule.EntityFramework;
using TodoModule.Web.Navigation;
using Abp.Web.Mvc;
using Abp.Application.Services;
using TodoModule.Todos;
using Abp.WebApi.Controllers.Dynamic.Builders;
using Abp.WebApi;
using Abp.Configuration.Startup;
using TodoModule.Web.App.Startup;
using System.Web.Optimization;
using Abp.Web.Mvc.Resources.Embedded;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;

namespace TodoModule.Web
{
    [DependsOn(typeof(AbpWebMvcModule), typeof(AbpWebApiModule), typeof(TodoApplicationModule), typeof(TodoEntityFrameworkModule))]
    public class TodoWebModule : AbpModule
    {
        public override void PreInitialize()
        {

            Configuration.Navigation.Providers.Add<TodoNavigationProvider>();

            Configuration.EmbeddedResources.Sources.Add(
                new EmbeddedResourceSet(
                    "/App/",
                    Assembly.GetExecutingAssembly(),
                    "TodoModule.Web.App"
                )
            );

        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(TodoAppService).Assembly, "todo")
                .Build();

            AppBundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
