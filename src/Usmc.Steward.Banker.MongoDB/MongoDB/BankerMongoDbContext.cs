using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Usmc.Steward.Banker.MongoDB;

[ConnectionStringName(BankerDbProperties.ConnectionStringName)]
public class BankerMongoDbContext : AbpMongoDbContext, IBankerMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureBanker();
    }
}
