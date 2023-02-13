using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ModelStateEgPrj.Models
{
    public class User
    {
        [Required(ErrorMessage = "Enter UserName")]
        [StringLength(15, ErrorMessage = "Name cannot be more than 15 characters")]
        [Display(Name = "First Name")]
        public string UFname { get; set; }
        [Display(Name = "Last Name")]
        public string ULname { get; set; }
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",
            ErrorMessage = "Enter Email in the Correct Format")]
        public string Email { get; set; }
        public int Age { get; set; }
    }
}