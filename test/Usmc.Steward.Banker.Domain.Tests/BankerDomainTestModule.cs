using Usmc.Steward.Banker.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Usmc.Steward.Banker;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(BankerEntityFrameworkCoreTestModule)
    )]
public class BankerDomainTestModule : AbpModule
{

}
