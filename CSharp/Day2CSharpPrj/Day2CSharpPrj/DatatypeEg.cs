using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2CSharpPrj
{
    class DatatypeEg
    {
        string str;
        static void Main()
        {
            Console.WriteLine("Min Value={0}", int.MinValue);
            Console.WriteLine("Max Value={0}", int.MaxValue);

            int num = 10;
            bool b;
            if (num == 10)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            Console.WriteLine($"Number =={num} is {b}");

            //the above can be replaced as below using ternary operator
            bool b1 = num == 10 ? true : false;
            Console.WriteLine($"Number =={num} is {b1}");
            //implicit and explicit conversions
            int i = 100;
            float f = i; //implicit
            Console.WriteLine(i);
            Console.WriteLine(f);
            f = 12434563456757.45f;
            i = (int)f; //explicit typecasting
            Console.WriteLine(f);
            Console.WriteLine(i);
           // i = Convert.ToInt32(f); //explicit conversion method of C#
            Console.WriteLine(f);
            Console.WriteLine(i);
            Console.WriteLine("-------------");
            //example for try 
            string str = "500";
            i = int.Parse(str);
            Console.WriteLine(i);
            Console.WriteLine("-------------");
            //example for tryparse
            string str2 = "250";
            int x = 0;
            bool success = int.TryParse(str2, out x);
            if(success)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("Invalid Data");
            }

            //boxing and unboxing
            object obj;
            obj = i; //boxing ( value type to reference type )
            string s = "AAA";
            obj = s; // implicit

            float sal;
            s = Console.ReadLine();
            Console.WriteLine("Enter details as required");
            sal = float.Parse(Console.ReadLine()); //unboxing (reference type to value type)
            //or
            //sal = Convert.ToSingle(Console.ReadLine());
            bool data = Convert.ToBoolean(Console.ReadLine());
            DateTime doj;
            doj = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine($"{sal},{data},{doj}");
            Console.Read();
        }
    }
}
