using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;

namespace Usmc.Steward.Banker.Seed;

public class BankerHttpApiHostDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly BankerSampleDataSeeder _bankerSampleDataSeeder;
    private readonly ICurrentTenant _currentTenant;

    public BankerHttpApiHostDataSeedContributor(
        BankerSampleDataSeeder bankerSampleDataSeeder,
        ICurrentTenant currentTenant)
    {
        _bankerSampleDataSeeder = bankerSampleDataSeeder;
        _currentTenant = currentTenant;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        using (_currentTenant.Change(context?.TenantId))
        {
            await _bankerSampleDataSeeder.SeedAsync(context);
        }
    }
}
