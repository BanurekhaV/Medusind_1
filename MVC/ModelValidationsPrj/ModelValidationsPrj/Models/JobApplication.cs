using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using ModelValidationsPrj.CustomClasses;

namespace ModelValidationsPrj.Models

{
    public class JobApplication
    {
        [Required]
        [Display(Name ="Applicant Name")]
        public string name { get; set; }
        [Required]
        [Range(3,10,ErrorMessage ="Experience must be between 3 and 10 years")]
        [Display(Name ="Years Of Experience")]
        public int experience { get; set; }
        [Display(Name ="DOB")]
        [DataType(DataType.Date)]
        [ValidBirthDate(ErrorMessage ="DOB should be between 01/01/1980 & 31/12/2001")]
        public DateTime birthdate { get; set; }
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",
            ErrorMessage ="Invalid Mail id")]
        public string email { get; set; }
        [ValidGender(ErrorMessage ="Please Select Your Gender")]
        public string gender { get; set; }
        [RegularExpression(@"^(0(?!\.00)|[1-9]\d{0,6})\.\d{2}$",
            ErrorMessage ="Salary Should be like 8000.50")]
        [Display(Name ="Expected Salary")]
        public decimal expsal { get; set; }
        [ValidSkills(ErrorMessage="Select a minimum of 3 skills")]
        public List<CheckBox>skills { get; set; }
        [Required]
        [Display(Name ="Do You Have a Valid Passport ?")]        
        public string havePassport { get; set; }
    }
}