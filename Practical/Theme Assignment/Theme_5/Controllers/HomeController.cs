using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Theme_5.Models;

namespace Theme_5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Blog() { 
            return View();
        }
        public IActionResult BlogDetails() {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult ProjectDetails()
        {
            return View();
        }
        public IActionResult Project() {
            return View();
        }
        public IActionResult StarterPage() {
            return View();
        }
        public IActionResult ServiceDetails() {
            return View();
        }
        public IActionResult Service() { 
            return View();
        }
    }
}
