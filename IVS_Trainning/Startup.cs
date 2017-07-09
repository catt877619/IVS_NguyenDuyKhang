using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IVS_Trainning.Startup))]
namespace IVS_Trainning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
