using Volo.Abp.Reflection;

namespace Usmc.Steward.Banker.Permissions;

public class BankerPermissions
{
    public const string GroupName = "Banker";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(BankerPermissions));
    }
}
