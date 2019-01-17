using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EnvironmentBasedStartupClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) 
        {
            var assemblyName = typeof(Startup).Assembly.FullName;

            // 使用接受組件名稱的 UseStartup(String) 版本
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup(assemblyName);
        }
    }
}
