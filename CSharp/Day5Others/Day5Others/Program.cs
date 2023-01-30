using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Others
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add("Medusind");
            al.Add('g');
            al.Add(56.45f);
            Console.WriteLine("The Count of al is {0}", al.Count);
            Console.WriteLine("the capacity of al is {0}", al.Capacity);
            //to display values stored in the above collection
            foreach(var item in al)
            {
                Console.WriteLine(item);
            }

            //to insert an element in  a particular index
            al.Insert(1, true);
            Console.WriteLine("-------------");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            //to insert or add a range of values
            ArrayList al2 = new ArrayList();
            al2.Add(5);
            al2.Add(2);
            al2.Add(8);
            al2.Add(15);
            al2.Add(6);
            al2.Add(1);

           // al.InsertRange(2, al2);
            al.AddRange(al2);

            Console.WriteLine("-------------");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------count n capacity---------");
            Console.WriteLine("The Count of al is {0}", al.Count);
            Console.WriteLine("the capacity of al is {0}", al.Capacity);
            al2.Remove(5); //or
            al2.RemoveAt(0);
            Console.WriteLine("-------------");
            foreach (var item in al2)
            {
                Console.WriteLine(item);
            }

            al.Sort(); // error in sorting, b'coz the arraylist is heterogenous
            al2.Sort(); // sort is possible b'coz same data type
            foreach (var item in al2)
            {
                Console.WriteLine(item);
            }
            Console.Read();
            
        }
    }
}
