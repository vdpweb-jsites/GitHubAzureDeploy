using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitHubAzureDeploy.Startup))]
namespace GitHubAzureDeploy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
