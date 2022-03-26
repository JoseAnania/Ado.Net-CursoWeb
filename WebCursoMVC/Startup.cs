using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebCursoMVC.Startup))]
namespace WebCursoMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
