using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cliente.Startup))]
namespace Cliente
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
