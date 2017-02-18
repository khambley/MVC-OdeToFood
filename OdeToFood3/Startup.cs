using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OdeToFood3.Startup))]
namespace OdeToFood3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
