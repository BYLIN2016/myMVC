using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myMVC.Startup))]
namespace myMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
