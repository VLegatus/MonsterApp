using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MonsterApp.Startup))]
namespace MonsterApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
