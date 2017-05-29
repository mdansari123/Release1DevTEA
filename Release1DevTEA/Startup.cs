using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Release1DevTEA.Startup))]
namespace Release1DevTEA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
