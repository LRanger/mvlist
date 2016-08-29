using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using MobileVisit.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace MobileVisit.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<MobileVisit.EntityFramework.MobileVisitDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MobileVisit";
        }

        protected override void Seed(MobileVisit.EntityFramework.MobileVisitDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
