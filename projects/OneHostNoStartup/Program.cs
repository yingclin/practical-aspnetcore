using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace OneHostNoStartup
{
    public class Program
    {
        private static IHostingEnvironment HostingEnvironment { get; set; }
        private static IConfiguration Configuration { get; set; }

        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) =>
                {
                    HostingEnvironment = context.HostingEnvironment;
                    Configuration = config.Build();
                })
                // Startup.ConfigureServices
                .ConfigureServices(services =>
                {
                    services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
                })
                // Startup.Configure
                .Configure(app =>
                {
                    if (HostingEnvironment.IsDevelopment())
                    {
                        app.UseDeveloperExceptionPage();
                    }

                    app.UseMvc();
                });
    }
}
