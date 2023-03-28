using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Usmc.Steward.Banker.Blazor.WebAssembly;

[DependsOn(
    typeof(BankerBlazorModule),
    typeof(BankerHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
)]
public class BankerBlazorWebAssemblyModule : AbpModule
{

}
