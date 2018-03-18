using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NDPH.ViewDisplay.Startup))]
namespace NDPH.ViewDisplay
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
