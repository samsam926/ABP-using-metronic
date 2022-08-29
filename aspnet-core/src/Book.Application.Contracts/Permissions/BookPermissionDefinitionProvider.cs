﻿using Book.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Book.Permissions;

public class BookPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BookPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BookPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookResource>(name);
    }
}
