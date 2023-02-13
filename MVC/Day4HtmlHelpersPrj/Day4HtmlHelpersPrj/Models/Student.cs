using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Day4HtmlHelpersPrj.Models
{
    public class Student
    {
        [Display(Name ="Student Regn No:")]
        public int RollNo { get; set; }
        [Display(Name ="Student Name :")]
        public string Name { get; set; }       
        public string Gender { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
    }
}