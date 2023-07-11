using Lesson6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson6.Controllers
{
    [Route("anasehife")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("indeks/{id?}")]
        public IActionResult Index(int id)
        {
            return View();
        }

        [Route("mexfi")]
        public IActionResult Privacy(string a, int b)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}