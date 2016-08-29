using System.Linq;
using MobileVisit.EntityFramework;
using MobileVisit.MultiTenancy;

namespace MobileVisit.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly MobileVisitDbContext _context;

        public DefaultTenantCreator(MobileVisitDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
