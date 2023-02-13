using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day4Prj.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Department { get; set; }
        public Decimal Salary { get; set; }
        public int? AddressId { get; set; }
    }
}