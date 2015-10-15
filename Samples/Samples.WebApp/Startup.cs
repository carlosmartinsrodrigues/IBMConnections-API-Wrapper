using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Samples.WebApp.Startup))]
namespace Samples.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
