using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Triangle
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddControllers();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Triangle}/{action=Info}/");
                endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Triangle}/{action=IsEquilateral}/");
                endpoints.MapControllerRoute(
                 name: "default",
                 pattern: "{controller=Triangle}/{action=IsIsosceles}/");
                endpoints.MapControllerRoute(
                      name: "default",
                      pattern: "{controller=Triangle}/{action=IsRightAngledl}/");
                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Triangle}/{action=Perimeter}/");
            endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Triangle}/{action=Area}/");
            });
        }
    }
}
