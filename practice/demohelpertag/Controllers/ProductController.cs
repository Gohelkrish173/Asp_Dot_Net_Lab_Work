using Microsoft.AspNetCore.Mvc;

namespace demohelpertag.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
