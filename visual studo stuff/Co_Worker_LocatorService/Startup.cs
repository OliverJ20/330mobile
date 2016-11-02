using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Co_Worker_LocatorService.Startup))]

namespace Co_Worker_LocatorService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}