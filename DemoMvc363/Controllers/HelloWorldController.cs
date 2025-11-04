using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace DemoMvc363.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public string Index()
    {
        return "Vũ Trung Hanh- 2121050563";
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
}