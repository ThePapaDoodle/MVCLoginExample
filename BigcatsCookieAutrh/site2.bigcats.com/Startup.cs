using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(site2.bigcats.com.Startup))]
namespace site2.bigcats.com
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
