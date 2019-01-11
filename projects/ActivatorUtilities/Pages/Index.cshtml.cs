using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ActivatorUtilities.Pages
{
    public class IndexModel : PageModel
    {
        private readonly string _envName;

        public IndexModel(IServiceProvider provider)
        {
            // 利用 ActivatorUtilities 建立 CurrentEnvironment instance
            CurrentEnvironment envInstance = (CurrentEnvironment)Microsoft.Extensions.DependencyInjection
                .ActivatorUtilities.CreateInstance(provider, typeof(CurrentEnvironment));
                
            _envName = envInstance.Name;
        }

        public void OnGet()
        {
        }

        public string EnvironmentName => _envName;
    }

    public class CurrentEnvironment
    {
        private readonly IHostingEnvironment _env;

        public CurrentEnvironment(IHostingEnvironment env)
        {
            _env = env;
        }

        public string Name => _env.EnvironmentName;
    }
}