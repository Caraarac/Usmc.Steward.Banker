using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace Usmc.Steward.Banker.Seed;

/* You can use this file to seed some sample data
 * to test your module easier.
 *
 * This class is shared among these projects:
 * - Usmc.Steward.Banker.AuthServer
 * - Usmc.Steward.Banker.Web.Unified (used as linked file)
 */
public class BankerSampleDataSeeder : ITransientDependency
{
    public async Task SeedAsync(DataSeedContext context)
    {

    }
}
