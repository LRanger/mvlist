using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using MobileVisit.EntityFramework;

namespace MobileVisit
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(MobileVisitCoreModule))]
    public class MobileVisitDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MobileVisitDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
