using Volo.Abp.Modularity;

namespace Usmc.Steward.Banker;

[DependsOn(
    typeof(BankerApplicationModule),
    typeof(BankerDomainTestModule)
    )]
public class BankerApplicationTestModule : AbpModule
{

}
