using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Usmc.Steward.Banker.Blazor.Server;

[DependsOn(
    typeof(BankerBlazorModule),
    typeof(AbpAspNetCoreComponentsServerThemingModule)
    )]
public class BankerBlazorServerModule : AbpModule
{

}
