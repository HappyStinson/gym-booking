using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GymBooking.Startup))]
namespace GymBooking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
