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
                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedAccount = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequiredLength = 8;
                options.Lockout.MaxFailedAccessAttempts = 15;
                options.User.RequireUniqueEmail = true;
            })
                .AddEntityFrameworkStores<OrderSystemDbContext>()
                .AddDefaultTokenProviders();

            services.PostConfigure<CookieAuthenticationOptions>(IdentityConstants.ApplicationScheme,
              options =>
              {
                  options.LoginPath = "/Identity/Account/Login";
                  options.LogoutPath = "/Identity/Account/Logout";
                  options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                  options.SlidingExpiration = true;
                  options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
              });

            services.AddIdentityCore<User>()
    .AddRoles<Role>()
    .AddClaimsPrincipalFactory<UserClaimsPrincipalFactory<User, Role>>()
    .AddEntityFrameworkStores<OrderSystemDbContext>()
    .AddDefaultTokenProviders()
    .AddDefaultUI();

            RegisterServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
            UserManager<User> userManager,
            RoleManager<Role> roleManager)
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IBrandsDatabaseService, BrandsDatabaseService>();


        }
    }
}
