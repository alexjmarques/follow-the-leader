using Abp.Authorization;
using impulso.Authorization.Roles;
using impulso.Authorization.Users;

namespace impulso.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
