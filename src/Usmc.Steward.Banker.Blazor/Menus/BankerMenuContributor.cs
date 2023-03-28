using System.Threading.Tasks;
using Usmc.Steward.Banker.Localization;
using Volo.Abp.UI.Navigation;

namespace Usmc.Steward.Banker.Blazor.Menus;

public class BankerMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private static async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        var l = context.GetLocalizer<BankerResource>();

        context.Menu.AddItem(new ApplicationMenuItem(BankerMenus.Prefix, displayName: "Sample Page", "/Banker", icon: "fa fa-globe"));

        await Task.CompletedTask;
    }
}
