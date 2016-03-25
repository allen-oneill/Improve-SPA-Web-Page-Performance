using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleOptimisation.Startup))]
namespace SampleOptimisation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
