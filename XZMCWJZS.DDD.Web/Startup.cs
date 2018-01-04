using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XZMCWJZS.DDD.Web.Startup))]
namespace XZMCWJZS.DDD.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
