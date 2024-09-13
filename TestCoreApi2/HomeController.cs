using Microsoft.AspNetCore.Mvc;

namespace TestCoreApi2
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
