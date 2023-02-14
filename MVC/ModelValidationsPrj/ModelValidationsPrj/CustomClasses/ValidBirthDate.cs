using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ModelValidationsPrj.Models;


namespace ModelValidationsPrj.CustomClasses
{
    //custom class for validation DOB
    public sealed class ValidBirthDate:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime entered_dob = Convert.ToDateTime(value);
            DateTime min_date = Convert.ToDateTime("01/01/1980");
            DateTime max_date = Convert.ToDateTime("31/12/2002");
            if (entered_dob >= min_date && entered_dob <= max_date)
                return ValidationResult.Success;
            else
                return new ValidationResult(ErrorMessage);
        }
    }

    public class ValidGender : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (Convert.ToString(value) == "M" || Convert.ToString(value) == "F")
                return ValidationResult.Success;
            else
                return new ValidationResult(ErrorMessage);
        }
    }

    public class ValidSkills: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            List<CheckBox> skillslist = value as List<CheckBox>;
            int count_skills = skillslist == null ? 0 : (from s in skillslist
                                                         where s.IsChecked == true
                                                         select s).Count();
            if (count_skills >= 3)
                return ValidationResult.Success;            
            else
                return new ValidationResult(ErrorMessage);

        }
    }
}