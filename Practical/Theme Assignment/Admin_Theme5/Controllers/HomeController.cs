using Admin_Theme5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Admin_Theme5.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View("Home");
        }
        public IActionResult Component()
        {
            return View();
        }
        public IActionResult Form()
        {
            return View();
        }
        public IActionResult Icons()
        {
            return View();
        }
        public IActionResult Notification()
        {
            return View();
        }
        public IActionResult Table()
        {
            return View();
        }
        public IActionResult Typography()
        {
            return View();
        }
    }
}
