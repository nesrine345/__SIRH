using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SIRH_DataBase;
using SIRH_DataBase.Entities;
using System;

namespace SIRH
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var service = scope.ServiceProvider;
                try
                {
                    var roleManager = service.GetRequiredService<RoleManager<IdentityRole>>();
                    var userManager = service.GetRequiredService<UserManager<ApplicationUser>>();
                    var context = service.GetRequiredService<DatabaseContext>();
                    Seed.SeedData(context, userManager, roleManager).Wait();
                }
                catch (Exception ex)
                {
                    var logger = service.GetRequiredService<ILogger>();
                    logger.LogError(ex, "error occured while migration");
                }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
