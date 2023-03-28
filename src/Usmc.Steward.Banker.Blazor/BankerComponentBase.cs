using Usmc.Steward.Banker.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Usmc.Steward.Banker.Blazor;

public abstract class BankerComponentBase : AbpComponentBase
{
    protected BankerComponentBase()
    {
        LocalizationResource = typeof(BankerResource);
    }
}
