using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using MobileVisit.EntityFramework;

namespace MobileVisit.Migrator
{
    [DependsOn(typeof(MobileVisitDataModule))]
    public class MobileVisitMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MobileVisitDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}