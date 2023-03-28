using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Usmc.Steward.Banker.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class BankerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Banker";
}
