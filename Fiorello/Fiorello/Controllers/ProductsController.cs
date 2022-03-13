using Microsoft.AspNetCore.Mvc;

namespace Fiorello.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
