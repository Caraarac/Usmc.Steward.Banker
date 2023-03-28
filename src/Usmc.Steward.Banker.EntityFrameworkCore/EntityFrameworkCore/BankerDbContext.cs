using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Usmc.Steward.Banker.EntityFrameworkCore;

[ConnectionStringName(BankerDbProperties.ConnectionStringName)]
public class BankerDbContext : AbpDbContext<BankerDbContext>, IBankerDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public BankerDbContext(DbContextOptions<BankerDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureBanker();
    }
}
