using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(baongan_lap456.Startup))]
namespace baongan_lap456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
