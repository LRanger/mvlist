using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using MobileVisit.Authorization;
using MobileVisit.MultiTenancy;

namespace MobileVisit.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : MobileVisitControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}