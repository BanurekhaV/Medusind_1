using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Others
{
    class GenericList
    {
        public static void Main()
        {
            List<int> intlist = new List<int>();
            intlist.Add(2);
            intlist.Add(10);
            intlist.Add(5);
            intlist.Add(8);
            intlist.Sort();
            foreach(int i in intlist)
            {
                Console.WriteLine(i);
            }

            //Dictionary
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Red");
            dict.Add(5,"Blue");
            dict.Add(2, "Green");
            dict.Add(6, "Yellow");

            foreach(string str in dict.Values)
            {
                Console.WriteLine(str);
            }

            //to iterate on both key and value
            foreach(KeyValuePair<int,string> kvp in dict)
            {
                Console.Write(kvp.Key + "\t");
                Console.Write(kvp.Value);
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
