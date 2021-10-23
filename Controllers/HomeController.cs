using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentRegistration.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() // Home
        {
            return View();
        }

        public IActionResult Privacy() // Privacy
        {
            return View();
        }

        public IActionResult SignUp() // Registration
        {
            return View();
        }

        // POST - When registration form is submitted from /SignUp
        [HttpPost]
        public IActionResult SignUp(string Student)
        {
            if (ModelState.IsValid) // If form data is valid and authentic
            {
                return RedirectToAction("Index"); // redirect to home
            } else
            {
                return RedirectToAction("SignUp"); // redirect to registration page
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
