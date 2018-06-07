using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoShopping.Startup))]
namespace GoShopping
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
