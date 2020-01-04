using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InfoWare.Startup))]
namespace InfoWare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
