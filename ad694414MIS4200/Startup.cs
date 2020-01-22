using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ad694414MIS4200.Startup))]
namespace ad694414MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
