using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TemplateAdminLTE.Startup))]
namespace TemplateAdminLTE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
