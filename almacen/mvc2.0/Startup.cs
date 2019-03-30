using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc2._0.Startup))]
namespace mvc2._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
