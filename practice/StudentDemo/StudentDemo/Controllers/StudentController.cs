using Microsoft.AspNetCore.Mvc;
using StudentDemo.Models;

namespace StudentDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index(StudentModel student)
        {
            if (!ModelState.IsValid) { 
                return View(student);
            }
            return View();
        }
    }
}
