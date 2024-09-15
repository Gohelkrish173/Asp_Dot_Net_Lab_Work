using Microsoft.AspNetCore.Mvc;

namespace Admin_Theme5.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Index()
        {
            return View("Table");
        }
    }
}
