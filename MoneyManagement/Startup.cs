using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoneyManagement.Startup))]
namespace MoneyManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
