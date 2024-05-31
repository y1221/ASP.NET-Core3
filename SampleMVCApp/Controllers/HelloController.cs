using Microsoft.AspNetCore.Mvc;

namespace SampleMVCApp.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            ViewData["message"] = "Hello World!";
            return View();
        }
    }
}
