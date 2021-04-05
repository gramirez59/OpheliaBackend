using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace Ophelia.Authorization
{
    public class OpheliaAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_Clientes, L("Clientes"));
            context.CreatePermission(PermissionNames.Pages_Productos, L("Productos"));
            context.CreatePermission(PermissionNames.Pages_Ventas, L("Ventas"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, OpheliaConsts.LocalizationSourceName);
        }
    }
}
