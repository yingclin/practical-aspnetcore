using Microsoft.AspNetCore.Mvc;

namespace RouteConstraint.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
          return View(RouteData.Values);
        }

        // id => 為int,最小值為1
        // 複合條件用 : 附加上去
        [Route("Product/{id:int:min(1)}")]

        public IActionResult Product(int id)
        {
            return View("Index", RouteData.Values);
        }

        // active => 為bool(true,FALSE)
        [Route("Play/{active:bool}")]

        public IActionResult IsGirl()
        {
            // 不利用 active 參數
            return View("Index", RouteData.Values);
        }

        // username => 長度介於2~20之間
        // 複合條件用 : 附加上去
        [Route("AddUser/{username:minlength(2):maxlength(20)}")]

        public IActionResult AddUser(string username)
        {
            return View("Index", RouteData.Values);
        }
    }
}