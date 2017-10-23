using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DigitalFeedback_UCW.Startup))]
namespace DigitalFeedback_UCW
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
