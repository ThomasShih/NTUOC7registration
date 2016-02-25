using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NTUOC7registration.Startup))]
namespace NTUOC7registration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
