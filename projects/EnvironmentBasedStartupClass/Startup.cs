using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace EnvironmentBasedStartupClass
{
    // Development environment Startup class
    public class StartupStaging
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.Run(async context => await context.Response.WriteAsync($"Use {nameof(StartupStaging)} class"));
        }
    }

    // Production environment Startup class
    public class StartupProduction
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.Run(async context => await context.Response.WriteAsync($"Use {nameof(StartupProduction)} class"));
        }
    }

    // default Startup class
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.Run(async context => await context.Response.WriteAsync($"Use {nameof(Startup)} class"));
        }
    }
}
