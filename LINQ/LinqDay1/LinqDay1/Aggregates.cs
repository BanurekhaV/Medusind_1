using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDay1
{
    class Aggregates
    {
        static int[] numbers = new int[] { 1, 2, 3, 4, 5 };
        static void SimpleAggregate()
        {
            var result = numbers.Sum();
            Console.WriteLine("Sum is {0}",result);
            result = numbers.Max();
            Console.WriteLine("Maximum is {0}",result);
        }

        static void AggregateFunc()
        {
            var agg = numbers.Aggregate(5,(a, b) => a * b);
            Console.WriteLine("The aggregate values is {0}", agg);
        }
        static void Main()
        {
            //SimpleAggregate();
            AggregateFunc();
            Console.Read();
        }
    }
}
