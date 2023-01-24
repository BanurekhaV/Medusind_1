using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2CSharpPrj
{
    class MethodsnParameters
    {
        //call by value
        public static void ValueMethod(int x)
        {
            x = 100;
            Console.WriteLine(x);
        }

        //call by reference 
        public static void ReferenceMethod(ref int y)
        {
            y = 100;
            Console.WriteLine(y);
        }

        //output parameter
        public static int Calculator(int a, int b, out int sum, out int product,out int diff )
        {
            sum = a + b;
            product = a * b;
            diff = a - b;
            int div = a / b;
            return div;
        }

    }

    class TestMethodsnParameters
    {
        public static void Main()
        {
            int a = 35;
            MethodsnParameters.ValueMethod(a);
            Console.WriteLine(a);
            Console.WriteLine("------call by Ref-----");
            MethodsnParameters.ReferenceMethod(ref a);
            Console.WriteLine(a);
            Console.WriteLine("-------out parameter--------");
            int division, total, prod, difference;
            division = MethodsnParameters.Calculator(20, 10, out total, out prod, out difference);
            Console.WriteLine($"Sum is :{total},Product is :{prod}, Difference is : {difference} and Division is : {division}");
            Console.Read();
        }
    }

}
