using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportTransfer4.Startup))]
namespace SportTransfer4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
