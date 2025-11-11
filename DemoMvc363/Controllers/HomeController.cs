using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMvc363.Models;

namespace DemoMvc363.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string Ten, int NamSinh)
        {
            int tuoi = DateTime.Now.Year - NamSinh;
            ViewBag.Ten = Ten;
            ViewBag.Tuoi = Tuoi;
            return View("Result");
        }

        [HttpGet]
        public IActionResult GiaiPTB2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GiaiPTB2(PTB2Model model)
        {
            double delta = model.B * model.B - 4 * model.A * model.C;
            string ketqua;

            if (model.A == 0)
            {
                if (model.B == 0)
                    ketqua = model.C == 0 ? "Phương trình vô số nghiệm" : "Phương trình vô nghiệm";
                else
                    ketqua = $"Phương trình có 1 nghiệm: x = {-model.C / model.B}";
            }
            else
            {
                if (delta < 0)
                    ketqua = "Phương trình vô nghiệm";
                else if (delta == 0)
                    ketqua = $"Phương trình có nghiệm kép x = {-model.B / (2 * model.A)}";
                else
                {
                    double x1 = (-model.B + Math.Sqrt(delta)) / (2 * model.A);
                    double x2 = (-model.B - Math.Sqrt(delta)) / (2 * model.A);
                    ketqua = $"Phương trình có 2 nghiệm: x1 = {x1}, x2 = {x2}";
                }
            }

            ViewBag.KetQua = ketqua;
            return View(model);
        }
    }
}
