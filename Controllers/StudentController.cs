using Microsoft.AspNetCore.Mvc;
using Crisan_Melisa_Lab1_Master.Models;

namespace Crisan_Melisa_Lab1_Master.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Info()
        {
            var student = new Student { Name = "Melisa Crisan", Age = 21 };
            ViewBag.Message = "Mesaj din Controller";
            ViewData["Time"] = DateTime.Now;
            return View(student);
        }
    }
}
