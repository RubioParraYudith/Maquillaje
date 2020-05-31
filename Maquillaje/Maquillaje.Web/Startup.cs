using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Maquillaje.Web.Startup))]
namespace Maquillaje.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
