using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Usmc.Steward.Banker.EntityFrameworkCore;

[ConnectionStringName(BankerDbProperties.ConnectionStringName)]
public interface IBankerDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
