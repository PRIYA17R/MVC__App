using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EFDbFirstApproachExample.ViewModel
{
    public class LoginViewModel
    {[Required (ErrorMessage = "Please enter UserName")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Please enter Password")]
        public string Password { get; set; }
    }
}