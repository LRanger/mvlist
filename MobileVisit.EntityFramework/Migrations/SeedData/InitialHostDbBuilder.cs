using MobileVisit.EntityFramework;
using EntityFramework.DynamicFilters;

namespace MobileVisit.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly MobileVisitDbContext _context;

        public InitialHostDbBuilder(MobileVisitDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
