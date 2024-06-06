using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CompanyJSL.Startup))]
namespace CompanyJSL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
