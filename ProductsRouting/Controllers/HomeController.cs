using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProductsRouting.Models;

namespace ProductsRouting.Controllers
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

    }
}
