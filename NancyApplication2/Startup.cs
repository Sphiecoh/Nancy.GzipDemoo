using Nancy;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(NancyApplication2.Startup))]

namespace NancyApplication2
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
        }
    }
}
