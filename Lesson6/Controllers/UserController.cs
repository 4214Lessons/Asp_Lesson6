using Lesson6.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson6.Controllers
{
    public class UserController : Controller
    {
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            return Redirect("/anasehife");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
