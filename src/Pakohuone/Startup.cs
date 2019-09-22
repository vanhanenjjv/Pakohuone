using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pakohuone.Data;
using Pakohuone.Models;
using Pakohuone.Services;

namespace Pakohuone
{
    public class Startup
    {
        public Startup(IConfiguration configuration) =>
            Configuration = configuration;
        
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var pakohuoneConfiguration = new PakohuoneConfiguration();
            Configuration.Bind("Pakohuone", pakohuoneConfiguration);
            services.AddSingleton(pakohuoneConfiguration);

            services.AddTransient<WorldService>();

            services.AddDbContext<PakohuoneContext>(options =>
                options.UseMySql(Configuration.GetConnectionString("Pakohuone")));

            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Admin}/{action=Index}/{id?}");
            });
        }
    }
}
