using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigBook.Startup))]
namespace GigBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
