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

        //params example 1
        public static int AddElements(params int[] arr)
        {
            int sum = 0;
            //i will be initiliazed to the start index of the array,
            //and will automatically move forward and will terminate once it reached the end of the elements
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }

        //params example 2
        public void ParamsMethod(params int[] numbers)
        {
            Console.WriteLine("There are {0} elements in the Array", numbers.Length);
            foreach(var i in numbers)
            {
                Console.WriteLine(i);
            }    
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
            Console.WriteLine("--------Params Array-------");
            int sum;
            sum=MethodsnParameters.AddElements(512,720,250,567,889);
            Console.WriteLine("The total is : {0}", sum);
            sum = MethodsnParameters.AddElements();
            Console.WriteLine("The total is : {0}", sum);
            Console.WriteLine("-----Params 2------");

            int[] num = new int[3];
            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            MethodsnParameters mnp = new MethodsnParameters();
            mnp.ParamsMethod(); //0 arguments
            mnp.ParamsMethod(num); //passing arraylist
            mnp.ParamsMethod(1, 2, 3, 4, 5, 6, 7); //comma seperated values
            Console.Read();
        }
    }

}
