using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3CSharpPrj
{
    struct Sample     //change it to class and see the difference
    {
        public int v1;
        public int v2;
    }
    enum MyCities : long
    {
        Ahmedabad=132,Bangalore=116,Chennai=175,Delhi=3,Kolkatta=405,Mumbai=71,Pune=56
       // Mumbai, Gauhati,Delhi,Mangalore,Hyderabad
    }
    class Program
    {
        int x;
        static void Main(string[] args)
        {
            //implicit datatype
            //int x;
            //var v = 10.67f;
            //Console.WriteLine(v);
            //v = '-';
            //Console.WriteLine(v);
            //dynamic d;
            //d = 'a';
            //d = 10;
            //d = "AAA";
            
            Sample s1 = new Sample(); // using constructor to instantiate
            s1.v1 = 10;
            s1.v2 = 20;
            Console.WriteLine(s1.v1 + s1.v2);
            Sample s2; // instantiation without constructor
            s2 = s1;
            Console.WriteLine(s2.v1 + s2.v2);
            s1.v1 = 40;
            s1.v2 = 50;
            Console.WriteLine("After Reassigning Values");
            Console.WriteLine(s1.v1 + s1.v2);
            Console.WriteLine(s2.v1 + s2.v2);

           // int city = (int)MyCities.Bangalore;
           // Console.WriteLine(city);
            string c = Convert.ToString(MyCities.Bangalore); //or
            c = MyCities.Bangalore.ToString();
            foreach(long i in Enum.GetValues(typeof(MyCities)))
            {
                Console.WriteLine(i);
            }

            foreach (string s in Enum.GetNames(typeof(MyCities)))
            {
                Console.WriteLine(s);
            }
            // Console.WriteLine(c);

            Console.Read();
        }
    }
}
