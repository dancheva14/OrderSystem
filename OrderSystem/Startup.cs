using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OrderSystem.Database;
using OrderSystem.Database.Models;
using OrderSystem.Services.Interfaces;
using OrderSystem.Services.Services;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Authentication.Cookies;
using System;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using OrderSystem.Services;

namespace OrderSystem
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
            services.AddControllersWithViews();
            services.AddMvc().AddRazorRuntimeCompilation();
            services.AddDbContext<OrderSystemDbContext>();

            services.AddIdentity<User, Role>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequiredLength = 5;
                options.Lockout.MaxFailedAccessAttempts = 15;
                options.User.RequireUniqueEmail = true;
            })
                .AddEntityFrameworkStores<OrderSystemDbContext>()
                .AddDefaultTokenProviders();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            
            RegisterServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env
            , UserManager<User> userManager,
            RoleManager<Role> roleManager,
            IRoleDatabaseService roleDbService)
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

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });


            IdentityDataInitializer.SeedData(userManager, roleManager, roleDbService).Wait();
        }

        private void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IBrandsDatabaseService, BrandsDatabaseService>();
            services.AddScoped<ICategoryDatabaseService, CategoryDatabaseService>();
            services.AddScoped<IPartnersDatabaseService, PartnersDatabaseService>();
            services.AddScoped<IStatusDatabaseService, StatusDatabaseService>();
            services.AddScoped<IPartsDatabaseService, PartsDatabaseService>();
            services.AddScoped<IOrdersDatabaseService, OrdersDatabaseService>();
            services.AddScoped<IUserDatabaseService, UserDatabaseService>();
            services.AddScoped<IRoleDatabaseService, RoleDatabaseService>();

            services.AddSingleton<ITempDataProvider, CookieTempDataProvider>();
        }
    }
}
