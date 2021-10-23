using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Models
{
    public class StudentRegistration
    {
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Display(Name = "Major")]
        public string Major { get; set; }

        [Display(Name = "Age")]
        [Range(0, 99, ErrorMessage = "Please enter a valid Age")]
        public int StudentAge { get; set; }

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Display(Name = "Confirm Email")]
        [Compare("EmailAddress", ErrorMessage = "The email address does not match.")]
        public string ConfirmEmail { get; set; }
    }
}
