using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilterExample2.Startup))]
namespace FilterExample2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
