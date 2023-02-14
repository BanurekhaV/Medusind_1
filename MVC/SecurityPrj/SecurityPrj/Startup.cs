using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecurityPrj.Startup))]
namespace SecurityPrj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
