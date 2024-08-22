using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeFlex.Startup))]
namespace HomeFlex
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
