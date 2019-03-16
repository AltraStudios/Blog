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
                .UseSqlServerStorage("DBContext");

            app.UseHangfireDashboard();
            app.UseHangfireServer();
        }
    }
}
