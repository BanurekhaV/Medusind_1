using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace FirstMVCProject.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name="Employee Name :")]
        public string Name { get; set; }
        [Display(Name ="Employee's Age :")]
        public int Age { get; set; }
    }

}