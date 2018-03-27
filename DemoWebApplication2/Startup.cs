using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoWebApplication2.Startup))]
namespace DemoWebApplication2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
