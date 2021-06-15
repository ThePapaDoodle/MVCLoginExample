using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(site1.bigcats.com.Startup))]
namespace site1.bigcats.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
