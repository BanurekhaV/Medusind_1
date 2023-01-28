using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4CSharpprj
{
    class Students
    {
        private string code = "N.A.";
        string name = "Not Known";
        int age = 0;

        //declare properties
        //1. for code field only get accessor
        public string _code
        {
            get { return code; }
        }

        //2. for name field
        public string stdname
        {
            get { return name; }
            set { name = value; }
        }
        //3. for age field
        public int Age
        {
            get { return age; }
            set { if (value <= 20) { age = 21; } else age = value; }
        }

        //overiding toString()

        public override string ToString()
        {
            return "Code = " + " " +code + "Name = " + " "+ name + "Age = " + age;
        }
    }
    class PropertiesEg
    {
        static void Main()
        {
            //create a students object
            Students student = new Students();
            // student._code = "S001"; read only property
            Console.WriteLine($"{student._code}, {student.stdname}, {student.Age}");
            student.stdname = "Priya";
            student.Age = 14;
            Console.WriteLine($"{student._code}, {student.stdname}, {student.Age}");
            student.Age += 2;
            Console.WriteLine("Student Info {0}",student.ToString());
            Console.Read();
        }
    }

    //automatic properties 
    class Product
    {
        public int ProductId { get; private set; }
        public string ProductName { get; protected set; }
        public float ProductPrice { get; }
        public DateTime Expiry { get; } = Convert.ToDateTime("31/12/2023");
    }
}
