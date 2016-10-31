using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BasicsOfForms.Startup))]
namespace BasicsOfForms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
