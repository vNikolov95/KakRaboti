using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KakRaboti.Startup))]
namespace KakRaboti
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
