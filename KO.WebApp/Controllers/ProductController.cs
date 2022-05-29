using Microsoft.AspNetCore.Mvc;
using KO.Service.Services;
using KO.Core.Models;

namespace KO.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly Service<Product> _service;
        public ProductController(Service<Product> service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _service.GetAllAsync());
        }

        public void YorumEkle()
        {

        }
    }
}
