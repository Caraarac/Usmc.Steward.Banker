using Usmc.Steward.Banker.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Usmc.Steward.Banker.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class BankerPageModel : AbpPageModel
{
    protected BankerPageModel()
    {
        LocalizationResourceType = typeof(BankerResource);
        ObjectMapperContext = typeof(BankerWebModule);
    }
}
