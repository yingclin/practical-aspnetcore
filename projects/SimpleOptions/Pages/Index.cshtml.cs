using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using SimpleOptions.Models;

namespace SimpleOptions.Pages
{
    public class IndexModel : PageModel
    {
        public MyOptions _options { get; private set; }

        public IndexModel(IOptionsMonitor<MyOptions> optionsAccessor)
        {
            _options = optionsAccessor.CurrentValue;
        }


        public string SimpleOptions { get; private set; }

        public void OnGet()
        {
            // ¨ú±o Options ªº­È
            var option1 = _options.Option1;
            var option2 = _options.Option2;
            SimpleOptions = $"option1 = {option1}, option2 = {option2}";
        }
    }
}