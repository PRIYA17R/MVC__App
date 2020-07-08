using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EFDbFirstApproachExample.ViewModel
{
    public class RegisterViewModel
    {
        [Required (ErrorMessage = "Username can not be blank")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password can not be blank")]
        public string Password { get; set; }

        [Required(ErrorMessage = "ConfirmPassword can not be blank")] 
        [Compare("Password", ErrorMessage ="Password should be matched")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email can not be blank")]
        [EmailAddress(ErrorMessage ="Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile can not be blank")]
        public string Mobile { get; set; }


        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "Date of Birth can not be blank")]
        public string DOB { get; set; }

        [Required(ErrorMessage = "Address can not be blank")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City can not be blank")]
        public string City { get; set; }

        [Required(ErrorMessage = "Country can not be blank")]

        public string Country { get; set; }

    }
}