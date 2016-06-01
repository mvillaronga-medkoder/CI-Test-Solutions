using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CI_Test_Web_Application.Startup))]
namespace CI_Test_Web_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
