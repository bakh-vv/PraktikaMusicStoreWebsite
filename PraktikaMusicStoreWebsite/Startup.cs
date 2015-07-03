using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PraktikaMusicStoreWebsite.Startup))]
namespace PraktikaMusicStoreWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
