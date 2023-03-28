using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Usmc.Steward.Banker.MongoDB;

[ConnectionStringName(BankerDbProperties.ConnectionStringName)]
public interface IBankerMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
