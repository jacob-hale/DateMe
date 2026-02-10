using System.Diagnostics;
using DateMe.Models;
using Microsoft.AspNetCore.Mvc;

namespace DateMe.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DatingApplication()
        {
            return View();

        }

        [HttpPost]
        public IActionResult DatingApplication(Application application)
        {
            return View("Confirmation", application);
        }
    }
}
