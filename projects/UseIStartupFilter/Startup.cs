using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using UseIStartupFilter.Middlewares;

namespace UseIStartupFilter
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // 註冊順序影響執行順序
            services.AddTransient<IStartupFilter, BeforeFooStartupFilter>();
            services.AddTransient<IStartupFilter, AfterFooStartupFilter>();
            services.AddTransient<IStartupFilter, BeforeBarStartupFilter>();
            services.AddTransient<IStartupFilter, AfterBarStartupFilter>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMiddleware<ConfigureCoolMiddleware>();

            app.Run(async context => await context.Response.WriteAsync("ConfigureEnd"));            
        }
    }

    #region IStartupFilter implements

    public class BeforeFooStartupFilter : IStartupFilter
    {
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            return builder =>
            {
                builder.UseMiddleware<BeforeFooMiddleware>();
                next(builder);
            };
        }
    }

    public class AfterFooStartupFilter : IStartupFilter
    {
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            return builder =>
            {
                builder.UseMiddleware<AfterFooMiddleware>();
                next(builder);
            };
        }
    }

    public class BeforeBarStartupFilter : IStartupFilter
    {
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            return builder =>
            {
                builder.UseMiddleware<BeforeBarMiddleware>();
                next(builder);
            };
        }
    }

    public class AfterBarStartupFilter : IStartupFilter
    {
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            return builder =>
            {
                builder.UseMiddleware<AfterBarMiddleware>();
                next(builder);
            };
        }
    }

    #endregion    
}
