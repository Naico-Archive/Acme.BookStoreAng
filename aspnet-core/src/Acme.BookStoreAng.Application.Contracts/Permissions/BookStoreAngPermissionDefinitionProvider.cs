using Acme.BookStoreAng.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.BookStoreAng.Permissions
{
    public class BookStoreAngPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(BookStoreAngPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(BookStoreAngPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BookStoreAngResource>(name);
        }
    }
}
