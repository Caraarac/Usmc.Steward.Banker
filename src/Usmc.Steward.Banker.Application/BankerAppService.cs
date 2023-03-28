using Usmc.Steward.Banker.Localization;
using Volo.Abp.Application.Services;

namespace Usmc.Steward.Banker;

public abstract class BankerAppService : ApplicationService
{
    protected BankerAppService()
    {
        LocalizationResource = typeof(BankerResource);
        ObjectMapperContext = typeof(BankerApplicationModule);
    }
}
