using Microsoft.AspNetCore.Mvc;

namespace Test_1.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
