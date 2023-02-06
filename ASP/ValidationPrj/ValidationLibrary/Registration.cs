using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ValidationLibrary
{
    public class Registration
    {
        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Password is must")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage ="Confirm Password is a must")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ComparePassword { get; set; }
        [Required(ErrorMessage ="Age is needed")]
        [Range(typeof(int),"18", "35",ErrorMessage ="Age to be between 18 and 35 only")]
        public int Age { get; set; }
        [Required(ErrorMessage ="Email is Required")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage ="Please enter email in the correct format")]
        public string Email { get; set; }
    }
}
