using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Day5Others
{
    class HashTableEg
    {
        public static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("E001", "Amit");
            ht.Add("E006", "Mirza");
            ht.Add("E003", "Murali");
            ht.Add(11, "Abbas");
            ht.Add("E002", "Jeet");
            ht.Add("E005", "Kauselya");

            //iterating the collection
            foreach(var item in ht.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");
            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);
            }

            //in order to iterate on both key and or value, use DictionaryEntry
            //foreach(DictionaryEntry de in ht)
            //{
            //    Console.Write(de.Key + "\t");
            //    Console.Write(de.Value);
            //    Console.WriteLine();
            //}

            ////to search the hash table using a key or value
            //Console.WriteLine("Enter a Key to search :");
            //string eid = Console.ReadLine();
            //if(ht.ContainsKey(eid))
            //{
            //    Console.WriteLine(eid + "=" + ht[eid]);
            //}
            //else
            //    Console.WriteLine(eid + "  does not exists");

            ////sorted list
            //SortedList sl = new SortedList();
            //sl.Add("ora", "Oracle");
            //sl.Add("vb", "Visual basic");
            //sl.Add("cs", "CSharp");
            //sl.Add("asp", "Asp.net");

            //foreach(DictionaryEntry de in sl)
            //{
            //    Console.Write(de.Key + " " + de.Value);
            //    Console.WriteLine();
            //}

            //stack
            Stack st = new Stack();
            st.Push(10);
            st.Push(20);
            st.Push(30);

            foreach(object o in st)
            {
                Console.WriteLine(o);                
            }
            Console.WriteLine(st.Peek());
            st.Pop();
            Console.WriteLine("---------------");
            foreach (object o in st)
            {
                Console.WriteLine(o);
            }
            Console.Read();
        }
    }
}
