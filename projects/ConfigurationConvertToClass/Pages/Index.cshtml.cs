using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace ConfigurationConvertToClass.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
        }

        public string[] GetWidgetsKeys() => _configuration.AsEnumerable()
            .Select(o => o.Key)
            .Where(o => o.Contains("widgets"))
            .ToArray();

        // 以 Get 方式轉設定值
        public Widgets GetWidgets() => _configuration.GetSection("widgets").Get<Widgets>();

        // 以 Bind 方式轉設定值
        public Widgets BindWidgets()
        {
            var widgets = new Widgets();
            _configuration.GetSection("widgets").Bind(widgets);
            return widgets;
        }
    }

    #region Configuration classes

    public class Widgets
    {
        public Layout Layout { get; set; }
        public Display Display { get; set; }

        public string ToJson() => JsonConvert.SerializeObject(this);
    }

    public class Layout
    {
        public string Name { get; set; }
        public int Layer { get; set; }
    }

    public class Display
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }

    #endregion
}