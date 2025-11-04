using Microsoft.AspNetCore.Mvc;
using DemoMvc363.Models.Entities;

namespace DemoMvc363.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(student s)
        {
            if (!ModelState.IsValid) return View(s);
            return View("Result", s);
        }
    }
}
