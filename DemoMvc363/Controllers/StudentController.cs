using Microsoft.AspNetCore.Mvc;
using DemoMvc363.Models;

namespace DemoMvc363.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}