using Microsoft.AspNetCore.Mvc;

namespace DemoMvc363.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index(string name)
        {
            ViewBag.Name = name ?? "Chưa nhập tên";
            return View();
        }
    }
}
