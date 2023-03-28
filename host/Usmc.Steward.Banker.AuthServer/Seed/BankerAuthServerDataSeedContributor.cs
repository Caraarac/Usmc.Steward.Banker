using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;

namespace Usmc.Steward.Banker.Seed;

public class BankerAuthServerDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly BankerSampleIdentityDataSeeder _bankerSampleIdentityDataSeeder;
    private readonly BankerAuthServerDataSeeder _bankerAuthServerDataSeeder;
    private readonly ICurrentTenant _currentTenant;

    public BankerAuthServerDataSeedContributor(
        BankerAuthServerDataSeeder bankerAuthServerDataSeeder,
        BankerSampleIdentityDataSeeder bankerSampleIdentityDataSeeder,
        ICurrentTenant currentTenant)
    {
        _bankerAuthServerDataSeeder = bankerAuthServerDataSeeder;
        _bankerSampleIdentityDataSeeder = bankerSampleIdentityDataSeeder;
        _currentTenant = currentTenant;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        using (_currentTenant.Change(context?.TenantId))
        {
            await _bankerSampleIdentityDataSeeder.SeedAsync(context);
            await _bankerAuthServerDataSeeder.SeedAsync(context);
        }
    }
}
