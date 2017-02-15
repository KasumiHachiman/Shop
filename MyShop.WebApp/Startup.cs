using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShop.WebApp.Startup))]
namespace MyShop.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        { 
            ConfigureAuth(app);
        }
    }
}
