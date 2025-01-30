using Microsoft.AspNetCore.Mvc;

namespace ProjectManager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
