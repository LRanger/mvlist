using Abp.Authorization;
using MobileVisit.Authorization.Roles;
using MobileVisit.MultiTenancy;
using MobileVisit.Users;

namespace MobileVisit.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
