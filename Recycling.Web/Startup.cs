using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Recycling.Web.Startup))]
namespace Recycling.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
