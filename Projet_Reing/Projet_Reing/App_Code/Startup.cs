using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projet_Reing.Startup))]
namespace Projet_Reing
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
