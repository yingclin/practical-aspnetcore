using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FileConfigurationProvider
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        public static IWebHostBuilder CreateDefaultBuilder(string[] args)
        {
            var builder = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                // 載入設定內容
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    // 載入 INI
                    config.AddIniFile("config.ini", optional: true, reloadOnChange: true);
                    // 載入 XML
                    config.AddXmlFile("config.xml", optional: true, reloadOnChange: true);
                    // 載入 JSON
                    config.AddJsonFile("config.json", optional: true, reloadOnChange: true);
                });

            return builder;
        }   
    }
}
