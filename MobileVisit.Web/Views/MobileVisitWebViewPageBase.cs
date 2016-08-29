using Abp.Web.Mvc.Views;

namespace MobileVisit.Web.Views
{
    public abstract class MobileVisitWebViewPageBase : MobileVisitWebViewPageBase<dynamic>
    {

    }

    public abstract class MobileVisitWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MobileVisitWebViewPageBase()
        {
            LocalizationSourceName = MobileVisitConsts.LocalizationSourceName;
        }
    }
}