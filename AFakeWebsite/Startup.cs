using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AFakeWebsite.Startup))]
namespace AFakeWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
