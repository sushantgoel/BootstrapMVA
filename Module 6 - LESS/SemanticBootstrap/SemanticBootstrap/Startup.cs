using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SemanticBootstrap.Startup))]
namespace SemanticBootstrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
