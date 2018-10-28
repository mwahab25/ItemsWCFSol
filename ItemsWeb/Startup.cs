using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ItemsWeb.Startup))]
namespace ItemsWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
