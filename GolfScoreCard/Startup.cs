using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GolfScoreCard.Startup))]
namespace GolfScoreCard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
