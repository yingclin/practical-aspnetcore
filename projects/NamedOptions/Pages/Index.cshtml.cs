using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using SimpleOptions.Models;

namespace NamedOptions.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MyOptions _named_options_1;
        private readonly MyOptions _named_options_2;

        public IndexModel(IOptionsSnapshot<MyOptions> namedOptionsAccessor)
        {
            // 用 Get(xxx) 取得命名的選項
            _named_options_1 = namedOptionsAccessor.Get("named_options_1");
            _named_options_2 = namedOptionsAccessor.Get("named_options_2");
        }

        public string NamedOptions1 { get; private set; }
        public string NamedOptions2 { get; private set; }

        public void OnGet()
        {
            var named_options_1 =
                $"named_options_1: option1 = {_named_options_1.Option1}, " +
                $"option2 = {_named_options_1.Option2}";
            var named_options_2 =
                $"named_options_2: option1 = {_named_options_2.Option1}, " +
                $"option2 = {_named_options_2.Option2}";
                
            NamedOptions1 = named_options_1;
            NamedOptions2 = named_options_2;
        }
    }
}