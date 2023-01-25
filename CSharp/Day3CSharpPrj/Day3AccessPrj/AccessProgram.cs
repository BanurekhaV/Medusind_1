using Day3CSharpPrj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day3AccessPrj
{
     class AccessProgram : Employee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi from Access project");
            Employee employee = new Day3CSharpPrj.Employee();
            employee.Empname = "ShahRukh Khan";
            
            employee.ShowEmp();
            AccessProgram ap = new AccessProgram();
            ap.phone = 6789; //protected member
            ap.email = "dd.com"; //it treats it only as protected
            Console.Read();
        }
    }

    
}
