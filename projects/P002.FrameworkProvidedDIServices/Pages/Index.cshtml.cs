using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace P002.FrameworkProvidedDIServices.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly ILogger<IndexModel> _logger1;
        private readonly ILogger<IndexModel> _logger2;

        public IndexModel(IHostingEnvironment hostingEnvironemt,
            ILoggerFactory loggerFactory,
            ILogger<IndexModel> logger)
        {
            _hostingEnvironment = hostingEnvironemt;
            // 用同一個實例
            _logger1 = logger;
            // 每次都重新取得(產生)
            _logger2 = loggerFactory.CreateLogger<IndexModel>();
        }

        public void OnGet()
        {
        }

        public string EnvironmentName => _hostingEnvironment.EnvironmentName;

        public void LogInfoTo1(string message) => _logger1.LogInformation(message);

        public int Logger1HashCode => _logger1.GetHashCode();

        public void LogInfoTo2(string message) => _logger2.LogInformation(message);

        public int Logger2HashCode => _logger2.GetHashCode();
    }
}