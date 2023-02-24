using Abp.Authorization;
using CED.Authorization.Roles;
using CED.Authorization.Users;

namespace CED.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
