using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Others
{
    //declare  a delegate
    public delegate void EmpDelegate(string s);

    class Employees
    {
        public static void acceptemp(string s) //static or class method
        {
            Console.WriteLine("Hello " + s);
        }

        public void displayemp(string str) //instance method
        {
            Console.WriteLine(str);
        }

        public void Show() // instance method
        {
            Console.WriteLine( "I am Show method");
        }
    }
    class Delegates1
    {
        static void Main()
        {
            Employees eobj = new Employees();
            EmpDelegate edel1 = new EmpDelegate(Employees.acceptemp);
            EmpDelegate edel2 = new EmpDelegate(eobj.displayemp);
            //invoke the delegate objects
            edel1.Invoke("Medusind");
            edel2("Banurekha");
            Console.Read();
        }
    }
}
