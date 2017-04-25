using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication1_Zakh.Startup))]
namespace WebApplication1_Zakh
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
