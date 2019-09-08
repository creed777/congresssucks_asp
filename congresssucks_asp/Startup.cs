using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(congresssucks_asp.Startup))]
namespace congresssucks_asp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
