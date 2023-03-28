using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Usmc.Steward.Banker.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
