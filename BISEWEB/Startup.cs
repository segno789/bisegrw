using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BISEWEB.Startup))]
namespace BISEWEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
