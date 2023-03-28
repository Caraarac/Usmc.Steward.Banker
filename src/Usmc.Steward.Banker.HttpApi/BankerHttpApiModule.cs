using Localization.Resources.AbpUi;
using Usmc.Steward.Banker.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Usmc.Steward.Banker;

[DependsOn(
    typeof(BankerApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class BankerHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(BankerHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<BankerResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
