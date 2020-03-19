using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(DanubeJourney.Web.Areas.Identity.IdentityHostingStartup))]

namespace DanubeJourney.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => { });
        }
    }
}
