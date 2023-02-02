using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            //query syntax
            string[] fruits = { "Oranges", "Apples", "Mangoes", "Bananas", "Grapes", "Avacado" };
            #region
            //query formation or declaration
            var mydata = from f in fruits
                         where f.StartsWith("A")
                         select f;

            IEnumerable<string> mydata2 = from a in fruits
                                          where a.Contains('o')
                                          orderby a
                                          select a.ToString(); // immediate execution

            #endregion

            //query execution
            foreach (var f in mydata)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine("---------------");
            foreach(var s in mydata2)
            {
                Console.WriteLine(s);
            }

            //Method Syntax
            List<int> numbers = new List<int>() { 16, 23, 12, 19, 42, 28, 57, 7, 9, 30 };
            var square = numbers.Select(x => x * x);

            foreach(var v in square)
            {
                Console.Write("{0}", v);
                Console.Write("  ");
            }

           
            //all odd numbers
            //Query syntax

            IEnumerable<int> Oddnos = from num in numbers
                                      where (num % 2) != 0
                                      select num;

           
            foreach(int x in Oddnos)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();

        }
    }
}
