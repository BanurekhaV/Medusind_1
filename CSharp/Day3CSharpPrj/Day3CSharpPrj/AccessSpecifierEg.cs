using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3CSharpPrj
{
    public class Employee
    {
       private int Empid;
       public string Empname;
        internal float Empsal;
        protected int phone;
        protected internal string email;

        public void GetEmp()
        {
            Console.WriteLine("Enter Emp Data :");
            Empid = Convert.ToInt32(Console.ReadLine());
            Empname = Console.ReadLine();
            Empsal = Convert.ToSingle(Console.ReadLine());
        }

        public void ShowEmp()
        {
            Console.WriteLine($"{Empid},{Empname},{Empsal}");
        }
        static void Main()
        {
            Employee e = new Employee();
            e.GetEmp();
            e.ShowEmp();

            AccessSpecifierEg aeg = new AccessSpecifierEg();
            aeg.testfunction();
            Console.Read();
        }
    }

    class AccessSpecifierEg
    {
        public void testfunction()
        {
            Employee emp = new Employee();
            emp.Empname = "New Emp";
            emp.Empsal = 3500;
            emp.email = "aa.com"
;           // emp.GetEmp();
            emp.ShowEmp();           
        }
    }

    class child : Employee
    {
        public void childfunction()
        {
            Employee e1 = new Employee();
            e1.Empsal = 2000;
            e1.email = "bb.com";
            child c = new child();
            c.Empsal = 3000;
            c.phone = 12345;
            c.email = "cc.com";
        }
    }
}
