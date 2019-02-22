using Microsoft.Owin;
using Owin;
using Unity;

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
