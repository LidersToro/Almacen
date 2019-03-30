using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(almacen.Startup))]
namespace almacen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
