using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Banco_de_Curriculo.Startup))]
namespace Banco_de_Curriculo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
