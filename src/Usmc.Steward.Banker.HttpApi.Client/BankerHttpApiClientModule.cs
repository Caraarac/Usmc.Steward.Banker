using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Usmc.Steward.Banker;

[DependsOn(
    typeof(BankerApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class BankerHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(BankerApplicationContractsModule).Assembly,
            BankerRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<BankerHttpApiClientModule>();
        });
    }
}
