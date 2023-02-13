using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ModelValidationsPrj.Models
{
    public class JobApplication
    {
        [Required]
        [Display(Name ="Applicant Name")]
        public string name { get; set; }
        [Range(3,10,ErrorMessage ="Experience must be between 3 and 10 years")]
        [Display(Name ="Years Of Experience")]
        public int experience { get; set; }
        [Display(Name ="DOB")]
        [DataType(DataType.Date)]
        public DateTime birthdate { get; set; }
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",
            ErrorMessage ="Invalid Mail id")]
        public string email { get; set; }
        public string gender { get; set; }
        [RegularExpression(@"^(0(?!\.00)|[1-9]\d{0,6})\.\d{2}$",
            ErrorMessage ="Salary Should be like 8000.50")]
        [Display(Name ="Expected Salary")]
        public decimal expsal { get; set; }
        public List<CheckBox>skills { get; set; }
        [Required]
        [Display(Name ="Do You Have a Valid Passport ?")]
        public string havePassport { get; set; }
    }
}