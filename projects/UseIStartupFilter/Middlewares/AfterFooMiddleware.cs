﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UseIStartupFilter.Middlewares
{
    public class AfterFooMiddleware
    {
        private readonly RequestDelegate _next;

        public AfterFooMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine($"{GetType().Name}.Invoke");

            await _next(context);
            await context.Response.WriteAsync($":{GetType().Name}:");
        }
    }
}
