using System.Web.Mvc;

namespace OPUS.Web.Areas.UnderGround
{
    public class UnderGroundAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "UnderGround";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "UnderGround_default",
                "UnderGround/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}