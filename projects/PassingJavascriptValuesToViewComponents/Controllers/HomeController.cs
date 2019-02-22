using Microsoft.AspNetCore.Mvc;
using PassingJavascriptValuesToViewComponents.ViewModels;

namespace PassingJavascriptValuesToViewComponents.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
          return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LoadComponent(MyComponentModel model)
        {
            return ViewComponent("MyComponent", model);
        }
    }
}