using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QA_inventory_1.Startup))]
namespace QA_inventory_1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
