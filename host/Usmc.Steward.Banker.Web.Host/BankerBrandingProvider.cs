using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Usmc.Steward.Banker;

[Dependency(ReplaceServices = true)]
public class BankerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Banker";
}
