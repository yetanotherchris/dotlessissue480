using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dotlessIssue480.Startup))]
namespace dotlessIssue480
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
