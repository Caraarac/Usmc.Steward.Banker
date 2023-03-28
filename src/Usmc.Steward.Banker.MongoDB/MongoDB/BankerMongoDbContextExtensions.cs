using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Usmc.Steward.Banker.MongoDB;

public static class BankerMongoDbContextExtensions
{
    public static void ConfigureBanker(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
