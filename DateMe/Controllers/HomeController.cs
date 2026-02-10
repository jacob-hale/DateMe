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

    }
}
