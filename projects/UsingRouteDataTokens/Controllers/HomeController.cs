using Microsoft.AspNetCore.Mvc;

namespace UsingRouteDataTokens.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // 取得 DataTokens 的值,名稱:Name
            var nameTokenValue = RouteData.DataTokens["Name"];
            ViewBag.TokenName = nameTokenValue;

            return View();
        }
    }
}