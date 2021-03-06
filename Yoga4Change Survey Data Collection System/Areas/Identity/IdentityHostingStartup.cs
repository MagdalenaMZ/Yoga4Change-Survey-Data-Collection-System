using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Yoga4Change_Survey_Data_Collection_System.Areas.Identity.Data;

[assembly: HostingStartup(typeof(Yoga4Change_Survey_Data_Collection_System.Areas.Identity.IdentityHostingStartup))]
namespace Yoga4Change_Survey_Data_Collection_System.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Y4CIdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DefaultConnection")));

                services.AddIdentity<Y4CUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddDefaultUI()
                .AddEntityFrameworkStores<Y4CIdentityContext>()
                .AddDefaultTokenProviders();


                services.AddScoped<IUserClaimsPrincipalFactory<Y4CUser>,
            ApplicationUserClaimsPrincipalFactory
            >();
            });
        }
    }
}