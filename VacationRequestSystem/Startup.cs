using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VacationRequestSystem.Startup))]
namespace VacationRequestSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
