using Abp.Authorization;
using DiceGame.Authorization.Roles;
using DiceGame.Authorization.Users;

namespace DiceGame.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
