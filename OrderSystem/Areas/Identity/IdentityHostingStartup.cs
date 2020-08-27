using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(OrderSystem.Areas.Identity.IdentityHostingStartup))]
namespace OrderSystem.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            //builder.ConfigureServices((context, services) => {
            //    services.AddDbContext<OrderSystemContext>(options =>
            //        options.UseSqlServer(
            //            context.Configuration.GetConnectionString("OrderSystemContextConnection")));

            //    services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
            //        .AddEntityFrameworkStores<OrderSystemContext>();
            //});
        }
    }
}