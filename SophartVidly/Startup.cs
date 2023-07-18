using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SophartVidly.Startup))]
namespace SophartVidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
