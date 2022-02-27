using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShoppingCart.Services.Data;
using ShoppingCart.Services.Interfaces;
using ShoppingCart.Services.Repo;
using ShoppingCart.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();

            services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("MSSqlConnection")));
            services.AddRazorPages();
            services.AddScoped<IOrders, OrderRepo>();
            services.AddScoped<IOrdersDetails, OrderDetailsRepo>();
            services.AddScoped<IProducts, ProductsRepo>();
            services.AddScoped<IUsers, UsersRep>();
            services.AddScoped<ICartItems, CartItemssRepo>();
            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();

            //services.ConfigureApplicationCookie(
            //    options =>
            //    {
            //        options.LoginPath = new PathString("/Account/Login");
            //        options.AccessDeniedPath = new PathString("/Account/AccessDenied");
            //        options.LogoutPath = new PathString("/Account/Logout");
            //    });
            //inject AutoMapper service
            var config = new AutoMapper.MapperConfiguration(cfg =>{

                cfg.AddProfile(new AutomappperProfile());
            });
            var mapper = config.CreateMapper();
            //only the single time we have to map
            services.AddSingleton(mapper);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
      
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Users}/{action=Login}");
            });
         

        }
    }
}
