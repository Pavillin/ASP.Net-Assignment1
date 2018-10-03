using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RocketLeagueStats.Startup))]
namespace RocketLeagueStats
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
