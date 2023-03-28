using Usmc.Steward.Banker.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Usmc.Steward.Banker.Permissions;

public class BankerPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BankerPermissions.GroupName, L("Permission:Banker"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BankerResource>(name);
    }
}
