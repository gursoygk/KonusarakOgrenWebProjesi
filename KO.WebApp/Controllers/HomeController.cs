using Microsoft.AspNetCore.Mvc;

namespace KO.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
