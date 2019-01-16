using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace LaunchSettings
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.Run(async context => {
                // 平台針對預設支援的三個變數提供判斷 method
                //                
                // is Production
                if(env.IsProduction())
                {
                    await context.Response.WriteAsync("Production");
                }

                // is Staging
                if(env.IsStaging())
                {
                    await context.Response.WriteAsync("Staging");
                }

                // is Development
                if(env.IsDevelopment())
                {
                    await context.Response.WriteAsync("Development");
                }

                // 用 IsEnvironment() 判斷自定義變數值
                if(env.IsEnvironment("Development_Project_1"))
                {
                    await context.Response.WriteAsync("Development_Project_1");
                }

                var envText = $"\nIHostingEnvironment.EnvironmentName = {env.EnvironmentName}";
                await context.Response.WriteAsync(envText);
            });
        }
    }
}
