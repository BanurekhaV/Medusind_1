using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day5Extensionprj;
using MyCalculator2;

namespace Calculator_ClientPrj
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCalculator mycalc = new MyCalculator();
            Console.WriteLine(mycalc.Greetings("Hasmukh"));
            Console.WriteLine(mycalc.Add(10,20));
            //by using the concept of aggregation/composition
            // Addl_Calculator addlcalc = new Addl_Calculator();
            // Console.WriteLine(addlcalc.Subtract(20, 14)); 
            Console.WriteLine(mycalc.Subtract(15, 5));
            Console.WriteLine(mycalc.Product(5,4));
            mycalc.SimpleFunc();

            //Anonymous Type
            var v = 7;
            var my_a_type = new
            {
                 data1 = "CSharp",
                 data2 = 5,
                data3 = true
            };
            Console.WriteLine(my_a_type.GetType().ToString());
            
            Console.Read();
        }
    }
}
