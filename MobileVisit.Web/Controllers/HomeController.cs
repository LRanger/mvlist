using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace MobileVisit.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MobileVisitControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}