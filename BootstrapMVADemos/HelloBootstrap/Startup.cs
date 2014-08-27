using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloBootstrap.Startup))]
namespace HelloBootstrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
