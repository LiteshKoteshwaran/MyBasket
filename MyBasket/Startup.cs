using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyBasket.Startup))]
namespace MyBasket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
