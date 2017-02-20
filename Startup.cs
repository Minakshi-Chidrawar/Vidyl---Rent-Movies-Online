using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidyl.Startup))]
namespace Vidyl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
