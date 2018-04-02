using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ASP.NET_Web_Application_Azure_Mobile_App.Startup))]

namespace ASP.NET_Web_Application_Azure_Mobile_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}