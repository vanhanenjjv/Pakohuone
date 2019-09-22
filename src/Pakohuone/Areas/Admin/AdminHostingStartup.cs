using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Pakohuone.Areas.Admin.AdminHostingStartup))]
namespace Pakohuone.Areas.Admin
{
    public class AdminHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.Configure<FormOptions>(options =>
                {
                    options.ValueLengthLimit = 526628572;
                    options.MultipartBodyLengthLimit = 526628572;
                });
            });
        }
    }
}
