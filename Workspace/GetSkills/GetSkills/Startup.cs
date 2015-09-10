using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GetSkills.Startup))]
namespace GetSkills
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
