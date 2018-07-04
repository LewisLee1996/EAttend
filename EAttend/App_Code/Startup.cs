using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EAttend.Startup))]
namespace EAttend
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
