using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleNorthwind.Startup))]
namespace SampleNorthwind
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
