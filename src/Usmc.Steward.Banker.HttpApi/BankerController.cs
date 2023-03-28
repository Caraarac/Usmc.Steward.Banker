using Usmc.Steward.Banker.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Usmc.Steward.Banker;

public abstract class BankerController : AbpControllerBase
{
    protected BankerController()
    {
        LocalizationResource = typeof(BankerResource);
    }
}
