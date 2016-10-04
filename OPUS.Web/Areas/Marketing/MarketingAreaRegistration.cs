using System.Web.Mvc;

namespace OPUS.Web.Areas.Marketing
{
    public class MarketingAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Marketing";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Marketing_default",
                "Marketing/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "OPUS.Web.Areas.Marketing.Controllers" }
            );
        }
    }
}