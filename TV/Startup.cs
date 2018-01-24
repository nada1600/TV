using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TV.Startup))]
namespace TV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
