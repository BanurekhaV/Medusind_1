using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Others
{
    delegate int ArithmeticDelegate(int x, int y);
    class Delegates_AsParameters
    {
        static void Main()
        {
            DoOperation(10, 2, Multiply);
            DoOperation(10, 2, Divide);
            Console.Read();
        }

        static void DoOperation(int x, int y, ArithmeticDelegate Adel)
        {
            int z = Adel(x, y);  //delegate is being invoked with 2 arguments
            Console.WriteLine("The resultant of Operation is : {0}",z); // printing the return value from the delegate pointing function
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
