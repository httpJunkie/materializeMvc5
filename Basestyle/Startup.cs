using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Basestyle.Startup))]
namespace Basestyle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
