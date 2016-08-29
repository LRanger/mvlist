using System.Web.Mvc;

namespace MobileVisit.Web.Controllers
{
    public class AboutController : MobileVisitControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}