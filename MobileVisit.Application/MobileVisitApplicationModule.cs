using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace MobileVisit
{
    [DependsOn(typeof(MobileVisitCoreModule), typeof(AbpAutoMapperModule))]
    public class MobileVisitApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
