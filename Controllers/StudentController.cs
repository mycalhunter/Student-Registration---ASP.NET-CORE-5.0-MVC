using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentRegistration.Models;

namespace StudentRegistration.Controllers
{
    public class StudentController : Controller
    {
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
            }
            else
            {
                return RedirectToAction("SignUp"); // redirect to registration page
            }
        }
    }
}
