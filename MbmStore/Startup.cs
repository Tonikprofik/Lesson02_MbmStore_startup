using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MbmStore.Models.ViewModels;
using Microsoft.AspNetCore.Http;

namespace Lesson01 //MbmStore 
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //method called by runtime, use to add services to the container
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            services.AddSingleton <IHttpContextAccessor, HttpContextAccessor>();
            services.AddControllersWithViews();
            services.AddMemoryCache();
            services.AddSession();
        }

        //method called by runtime, use to configure HTTP request pipeline
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: null,
                    pattern: "Catalogue/category/Page{page:int}",
                    defaults: new
                    {
                        controller = "Catalogue",
                        action = "Index"
                    });

                endpoints.MapControllerRoute(
                    name: null,
                    pattern: "Page{page:int}",
                    defaults: new
                    {
                        controller = "Catalogue",
                        action = "Index",
                        productPage = 1
                    });
                endpoints.MapControllerRoute(
                    name: null,
                    pattern: "Catalogue/{category}", defaults: new
                    {
                        controller = "Catalogue",
                        action = "Index",
                        productPage = 1
                    });
                endpoints.MapControllerRoute(
                    name: null,
                    pattern: "", defaults: new
                    {
                        controller = "Catalogue",
                        action = "Index",
                        productPage = 1
                    });

                endpoints.MapControllerRoute(
                    name: "pagination",
                    pattern: "Catalogue/Page{page}",
                    defaults: new { Controller = "Catalogue", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}