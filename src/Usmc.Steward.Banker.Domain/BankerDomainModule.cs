using Volo.Abp.Caching;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Usmc.Steward.Banker;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(AbpCachingModule),
    typeof(BankerDomainSharedModule)
)]
public class BankerDomainModule : AbpModule
{

}
