using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace Usmc.Steward.Banker;

[DependsOn(
    typeof(BankerDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationAbstractionsModule)
    )]
public class BankerApplicationContractsModule : AbpModule
{

}
