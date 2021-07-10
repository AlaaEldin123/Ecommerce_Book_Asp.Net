using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookss.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Bookss.Bl;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Bookss
{
    public class Startup
    {
        /// <summary>
        /// when we remove the connection string from db to json, we have to put this constructor 
        /// in order to be used in line 40.
        /// </summary>
        IConfiguration config;
        public Startup(IConfiguration configuration)
        {
            config = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession();
            services.AddHttpContextAccessor();
            services.AddDistributedMemoryCache();
            //when we remove the connection string we have to add this line. 
            services.AddDbContext<NeStoreWebsiteContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            /// addscopped, to add the interfaces we made in Bl 
            services.AddScoped<IItemService, ClsItems>();
            services.AddScoped<ICategoryService, ClsCategories>();
            ///
            services.AddControllersWithViews();
            //add identity 
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<NeStoreWebsiteContext>();
            //add identity 

            //login and cookies 
            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = "/Users/AccessDenied";
                options.Cookie.Name = "Cookie";
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(720);
                options.LoginPath = "/Users/Login";
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.SlidingExpiration = true;
            });
            //login and cookies 
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSession();
            // Login and register 
            app.UseAuthentication();
            app.UseAuthorization();
            //Login and register

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "areas",
                   pattern: "{area:exists}/{controller=Home}/{action=Index}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
