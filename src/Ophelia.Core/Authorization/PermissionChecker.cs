using Abp.Authorization;
using Ophelia.Authorization.Roles;
using Ophelia.Authorization.Users;

namespace Ophelia.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
