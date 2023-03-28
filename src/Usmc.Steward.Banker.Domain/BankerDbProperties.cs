namespace Usmc.Steward.Banker;

public static class BankerDbProperties
{
    public static string DbTablePrefix { get; set; } = "Banker";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Banker";
}
