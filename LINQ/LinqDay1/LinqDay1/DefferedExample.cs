using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDay1
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    class DefferedExample 
    {
        static void Main()
        {
            var Employees = new List<Employee>
            {
                new Employee {ID=1, Name="Sujan",Salary=30000},
                new Employee {ID=2, Name="Raghunath",Salary=42000},
                new Employee {ID=3, Name="Bhupesh",Salary=54000},
            };

            //1. construct/format/declare
            //Deferred
            var emp = Employees.Where(x => x.Salary < 35000).Select(y => y.Name);

            //Immediate
            var emp1 = Employees.Where(x => x.Salary < 35000).Select(y => y.Name).ToList();
          
            //2. create another employee instance after query construction
            Employees.Add(new Employee { ID = 4, Name = "Mukesh", Salary = 20000 });

            //3. Execution of the constructed defferred query that gives latest data
            foreach(var e in emp)
            {
                Console.WriteLine(e);
            }

            //4. Execution of the constructed Immediate query that does not give latest data
            foreach (var e in emp1)
            {
                Console.WriteLine(e);
            }
            Console.Read();
        }
      
    }
}
