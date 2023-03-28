using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;
using Volo.Abp.Uow;

namespace Usmc.Steward.Banker.Seed;

public class BankerUnifiedDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly BankerSampleIdentityDataSeeder _sampleIdentityDataSeeder;
    private readonly BankerSampleDataSeeder _bankerSampleDataSeeder;
    private readonly IUnitOfWorkManager _unitOfWorkManager;
    private readonly ICurrentTenant _currentTenant;

    public BankerUnifiedDataSeedContributor(
        BankerSampleIdentityDataSeeder sampleIdentityDataSeeder,
        IUnitOfWorkManager unitOfWorkManager,
        BankerSampleDataSeeder bankerSampleDataSeeder,
        ICurrentTenant currentTenant)
    {
        _sampleIdentityDataSeeder = sampleIdentityDataSeeder;
        _unitOfWorkManager = unitOfWorkManager;
        _bankerSampleDataSeeder = bankerSampleDataSeeder;
        _currentTenant = currentTenant;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        await _unitOfWorkManager.Current.SaveChangesAsync();

        using (_currentTenant.Change(context?.TenantId))
        {
            await _sampleIdentityDataSeeder.SeedAsync(context);
            await _unitOfWorkManager.Current.SaveChangesAsync();
            await _bankerSampleDataSeeder.SeedAsync(context);
        }
    }
}
