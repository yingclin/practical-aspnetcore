using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UseIHostingEnvironment.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel(IHostingEnvironment hostingEnv)
        {
            ModelEnvironmentName = hostingEnv.EnvironmentName;
        }

        public void OnGet()
        {
        }

        public string ModelEnvironmentName { get; }
    }
}