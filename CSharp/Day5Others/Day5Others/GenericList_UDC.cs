using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Others
{
    class Employee
    {
        int empid;
        string empname;
        string companyname;
        float sal;

        //object initializers
        //List<Employee> elist = new List<Employee>()
        //{
        //    new Employee{empid=200,empname="Mayank",sal=34000},
        //    new Employee{empid=201,empname="kalicharan",sal=35000},
        //    new Employee{empid=203,empname="Vignesh",sal=35000},
        //};

        public Employee(int id, string name, string cname, float sal)
        {
            empid = id;
            empname = name;
            companyname = cname;
            this.sal = sal;
        }

        public override string ToString()
        {
            //companyname = "New Medusind Ltd.";
            return string.Format("Employeeid : " + empid + " With Employee Name : " + empname +
                " Works For : " + companyname + " and Earns " + sal);
        }
    }
    class GenericList_UDC
    {
        static void Main()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee(101, "Manya", "Medusind", 35000));
            emplist.Add(new Employee(103, "Apurva", "New Medusind", 35000));
            emplist.Add(new Employee(104, "Nandini", "Medusind Ltd.", 35000));
            emplist.Add(new Employee(102, "Kauselya", "Medusind Pvt. Ltd,", 35000));

            foreach (Employee e in emplist)
            {
                Console.WriteLine(e.ToString());

            }

            Console.Read();
        }
    }
}
