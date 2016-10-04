using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OPUS.Web.Startup))]
namespace OPUS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
