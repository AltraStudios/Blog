using Hangfire;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(HangfireWithDequeueBatch.Startup))]

namespace HangfireWithDequeueBatch
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration
                .UseSqlServerStorage("<name or connection string>");

            app.UseHangfireDashboard();
            app.UseHangfireServer();
        }
    }
}
