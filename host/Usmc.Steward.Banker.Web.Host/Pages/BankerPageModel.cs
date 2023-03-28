using Usmc.Steward.Banker.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Usmc.Steward.Banker.Pages;

public abstract class BankerPageModel : AbpPageModel
{
    protected BankerPageModel()
    {
        LocalizationResourceType = typeof(BankerResource);
    }
}
