using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace MemoryConfigurationProvider
{
    public class Program
    {
        private static readonly Dictionary<string, string> _dict = 
            new Dictionary<string, string>
            {
                {"section1:key1", "value1"},
                {"section1:key2", "value2"}
            };

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
                    // 載入 Dictionary
                    config.AddInMemoryCollection(_dict);
                });

            return builder;
        }   
    }
}
