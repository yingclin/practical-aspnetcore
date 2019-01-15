using Microsoft.AspNetCore.Mvc;

namespace RouteConstraint.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
          return View(RouteData.Values);
        }

        // id => ��int,�̤p�Ȭ�1
        // �ƦX����� : ���[�W�h
        [Route("Product/{id:int:min(1)}")]

        public IActionResult Product(int id)
        {
            return View("Index", RouteData.Values);
        }

        // active => ��bool(true,FALSE)
        [Route("Play/{active:bool}")]

        public IActionResult IsGirl()
        {
            // ���Q�� active �Ѽ�
            return View("Index", RouteData.Values);
        }

        // username => ���פ���2~20����
        // �ƦX����� : ���[�W�h
        [Route("AddUser/{username:minlength(2):maxlength(20)}")]

        public IActionResult AddUser(string username)
        {
            return View("Index", RouteData.Values);
        }
    }
}