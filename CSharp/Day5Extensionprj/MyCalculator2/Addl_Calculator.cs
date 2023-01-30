using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day5Extensionprj;

namespace MyCalculator2
{
    public static class Addl_Calculator
    {
        //MyCalculator dll1 = new MyCalculator(); //1st DLL class

                                 //adding a reference to the first dll class with a this keyword
                                 // to ensure extension methods of the first dll
        public static int Subtract(this MyCalculator dll1,int a, int b)
        {
            return a - b;
        }

        public static int Product(this MyCalculator mc, int a, int b)
        {
            return a * b;
        }

        public static void SimpleFunc(this MyCalculator mc)
        {
            Console.WriteLine("I am very Simple");
        }
    }
}
