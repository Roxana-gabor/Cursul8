using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cursul8.Startup))]
namespace Cursul8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
