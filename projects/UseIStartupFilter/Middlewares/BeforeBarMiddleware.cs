using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UseIStartupFilter.Middlewares
{
    public class BeforeBarMiddleware
    {
        private readonly RequestDelegate _next;

        public BeforeBarMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine($"{GetType().Name}.Invoke");

            await context.Response.WriteAsync($":{GetType().Name}:");
            await _next(context);
        }
    }
}
