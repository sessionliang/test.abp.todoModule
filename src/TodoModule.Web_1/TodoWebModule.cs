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
                    "/App/Main/views/",
                    Assembly.GetExecutingAssembly(),
                    "TodoModule.Web.Views"
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(TodoAppService).Assembly, "todo")
                .Build();
        }
    }
}
