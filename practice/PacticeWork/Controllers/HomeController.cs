using Microsoft.AspNetCore.Mvc;
using PacticeWork.Models;
using System.Diagnostics;

namespace PacticeWork.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.City = "Rajkot";
            ViewBag.Name = "Krish";
            ViewBag.Stu = new List<String>()
            {
                "krish","mehul","sachin"
            };

            TempData["Data"] = "i am from index action";
            List<Department> departments = new List<Department>();
            List<Designation> designations = new List<Designation>();
            List<Employee> employees = new List<Employee>();

            designations.Add(new Designation() { DesignationId = 1, DesignationName = "FrontEnd", DesignationCode = "FE" });
            designations.Add(new Designation() { DesignationId = 2, DesignationName = "BackEnd", DesignationCode = "BE" });


            return View();
        }
        public String Details() {
            return (string)TempData["Data"];
        }
    }
}
