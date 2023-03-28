using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Usmc.Steward.Banker.EntityFrameworkCore;

public class BankerHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<BankerHttpApiHostMigrationsDbContext>
{
    public BankerHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<BankerHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Banker"));

        return new BankerHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
