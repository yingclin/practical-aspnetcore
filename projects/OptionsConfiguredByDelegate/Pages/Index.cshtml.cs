using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using OptionsConfiguredByDelegate.Modles;

namespace OptionsConfiguredByDelegate.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MyOptionsWithDelegateConfig _optionsWithDelegateConfig;

        public IndexModel(IOptionsMonitor<MyOptionsWithDelegateConfig> optionsAccessorWithDelegateConfig)
        {
            _optionsWithDelegateConfig = optionsAccessorWithDelegateConfig.CurrentValue;
        }

        public string SimpleOptionsWithDelegateConfig { get; private set; }

        public void OnGet()
        {
            var delegate_config_option1 = _optionsWithDelegateConfig.Option1;
            var delegate_config_option2 = _optionsWithDelegateConfig.Option2;

            SimpleOptionsWithDelegateConfig =
                $"delegate_option1 = {delegate_config_option1}, " +
                $"delegate_option2 = {delegate_config_option2}";
        }
    }
}