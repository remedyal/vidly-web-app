using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyIdentitySample.Startup))]
namespace VidlyIdentitySample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
