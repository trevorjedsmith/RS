using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RS.Web.Startup))]
namespace RS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
