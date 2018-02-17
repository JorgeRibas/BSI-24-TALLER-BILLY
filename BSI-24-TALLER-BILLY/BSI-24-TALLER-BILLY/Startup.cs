using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BSI_24_TALLER_BILLY.Startup))]
namespace BSI_24_TALLER_BILLY
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
