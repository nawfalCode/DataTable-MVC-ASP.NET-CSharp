using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookEample.Startup))]
namespace BookEample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
