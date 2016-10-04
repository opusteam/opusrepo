using System.Web.Mvc;

namespace OPUS.Web.Areas.InC
{
    public class InCAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "InC";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "InC_default",
                "InC/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}