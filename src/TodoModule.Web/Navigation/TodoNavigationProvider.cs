using Abp.Application.Navigation;
using Abp.Localization;

namespace TodoModule.Web.Navigation
{
    public class TodoNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu.AddItem(
                new MenuItemDefinition(
                    TodoAppPageNames.Tasks,
                    L("Tasks"),
                    icon: "fa fa-tasks",
                    url: "todo",
                    requiresAuthentication: true
                )
            );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, TodoModuleConsts.LocalizationSourceName);
        }
    }
}
