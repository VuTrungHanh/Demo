using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DemoMvc.Controllers
{
    public class DemoController : Controller
    { 
        public IActionResult ViewExample()
        {
            ViewData["Message"] = "Đây là ví dụ về ViewResult — trả về một trang View.";
            return View();
        }

        public IActionResult RedirectExample()
        {
            return Redirect("https://www.google.com");
        }

        public IActionResult RedirectToActionExample()
        {
            return RedirectToAction("ViewExample");
        }

        public IActionResult JsonExample()
        {
            var student = new
            {
                Name = "Vũ Trung Hanh",
                Age = 22,
                Address = "Hà Nội"
            };
            return Json(student);
        }

        public IActionResult FileExample()
        {
            var fileBytes = Encoding.UTF8.GetBytes("Nội dung trong file demo.txt");
            var fileName = "demo.txt";
            return File(fileBytes, "text/plain", fileName);
        }

        public IActionResult StatusCodeExample()
        {
            return StatusCode(404, "Không tìm thấy tài nguyên yêu cầu!");
        }

        [HttpGet]
        public IActionResult Input()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Input(string name, int age)
        {
            ViewBag.Info = $"Tên: {name}, Tuổi: {age}";
            return View();
        }

    }
}
