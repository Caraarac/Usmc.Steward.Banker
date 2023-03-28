using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Usmc.Steward.Banker;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BankerHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class BankerConsoleApiClientModule : AbpModule
{

}
