using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PraGroupUnity.Startup))]
namespace PraGroupUnity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
