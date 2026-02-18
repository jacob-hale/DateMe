using System.Diagnostics;
using System.Runtime.InteropServices.Swift;
using DateMe.Models;
using Microsoft.AspNetCore.Mvc;

namespace DateMe.Controllers
{
    public class HomeController : Controller
    {
        private DatingApplicationContext _context;
        public HomeController(DatingApplicationContext temp)
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DatingApplication()
        {
            ViewBag.Majors = _context.Majors.OrderBy(x => x.MajorName).ToList();
            return View();

        }

        [HttpPost]
        public IActionResult DatingApplication(Application application)
        {

            _context.Applications.Add(application); // add record to database
            _context.SaveChanges(); // save changes to database

            return View("Confirmation", application);
        }

        public IActionResult WaitList()
        {
            var applications = _context.Applications
                .Where(x => x.CreeperStalker == false)
                .OrderBy(x => x.LastName).ToList();

            return View(applications);
        }
    }
}
