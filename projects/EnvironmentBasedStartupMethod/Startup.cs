using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace EnvironmentBasedStartupMethod
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IService, ConfigureService>();
        }

        public void ConfigureDevelopmentServices(IServiceCollection services)
        {
            services.AddTransient<IService, ConfigureDevelopmentService>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            var service = app.ApplicationServices.GetService<IService>();

            app.Run(async context => await context.Response.WriteAsync($"Use {nameof(Configure)}(); get service, Type = {service.GetType().Name}"));
        }

        public void ConfigureDevelopment(IApplicationBuilder app, IHostingEnvironment env)
        {
            var service = app.ApplicationServices.GetService<IService>();

            app.Run(async context => await context.Response.WriteAsync($"Use {nameof(ConfigureDevelopment)}(); get service, Type = {service.GetType().Name}"));
        }
    }

    #region services impl

    public interface IService
    { }

    public class ConfigureDevelopmentService : IService
    { }

    public class ConfigureService : IService
    { }

    #endregion
}
