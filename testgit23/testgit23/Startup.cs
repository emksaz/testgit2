using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testgit23.Startup))]
namespace testgit23
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
