using System.Web.Mvc;

namespace OPUS.Web.Areas.OverHead
{
    public class OverHeadAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "OverHead";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "OverHead_default",
                "OverHead/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}