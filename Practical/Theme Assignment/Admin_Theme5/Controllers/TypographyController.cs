using Microsoft.AspNetCore.Mvc;

namespace Admin_Theme5.Controllers
{
    public class TypographyController : Controller
    {
        public IActionResult Index()
        {
            return View("Typography");
        }
    }
}
