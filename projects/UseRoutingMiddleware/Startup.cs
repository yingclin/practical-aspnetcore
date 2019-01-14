using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace UseRoutingMiddleware
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        /// <summary>
        /// 路由必須設定在 Startup.Configure 方法中。 範例應用程式使用下列 API：
        /// * RouteBuilder
        /// * MapGet – 僅符合 HTTP GET 要求。
        /// * UseRouter
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // 啟用 index.html
            app.UseDefaultFiles();
            app.UseStaticFiles();

            // 自定義 Route Handler
            var trackPackageRouteHandler = new RouteHandler(context => {
                var routeValues = context.GetRouteData().Values;
                return context.Response.WriteAsync($"Hello! Route values: {string.Join(", ", routeValues)}");
            });

            var routeBuilder = new RouteBuilder(app, trackPackageRouteHandler);

            // 建立 3 個路由規則：
            // 1. /package，使用自定義的 Handler trackPackageRouteHandler
            // 2. /hello，並限定 http method = GET
            // 2. /hi，並限定 http method = POST

            routeBuilder.MapRoute(
                "Track Package Route", // name
                "package/{operation:regex(^track|create|detonate$)}/{id:int}"); // templates

            routeBuilder.MapGet("hello/{name}", context =>
            {
                var name = context.GetRouteValue("name");
                return context.Response.WriteAsync($"Hello, {name}");
            });

            routeBuilder.MapPost("hi/{name}", context =>
            {
                var name = context.GetRouteValue("name");
                return context.Response.WriteAsync($"Hi, {name}");
            });

            var routes = routeBuilder.Build();
            app.UseRouter(routes);
        }
    }
}
