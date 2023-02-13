using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day4HtmlHelpersPrj.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public city city { get; set; }
        public skills skills { get; set; }
        public bool IAccept { get; set; }
    }

    public enum city
    {
        Delhi, Mumbai, Kolkatta, Chennai, Bangalore
    }

    public enum skills
    {
        HTML5,CSS3,CSharp,MVC,ASP,WebAPI
    }
}

