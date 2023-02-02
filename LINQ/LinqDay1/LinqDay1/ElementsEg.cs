using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDay1
{
    class ElementsEg
    {
        static void Main()
        {
            //ElementAtfunc();
             FirstFunc();
           // SingleFunc();
            Console.Read();
        }

        static void ElementAtfunc()
        {
            string[] names = { "Yudhister", "Bheem", "Arjun", "Nakul", "Sahadev" };
            var result = names.ElementAt(1);
            Console.WriteLine(result);
            // result = names.ElementAt(5); //Argumentoutofrange exception
            result = names.ElementAtOrDefault(5);
            Console.WriteLine("-------");
            Console.WriteLine(result);
        }

        static void FirstFunc()
        {
            string[] cities = { "Agra", "Chennai", "Bhubaneshwar", "Bangalore", "Hyderabad", "Ahmedabad" };
            string[] mycities = {};
            var firstcity = cities.First();
            Console.WriteLine(firstcity);
            // var city = mycities.First(); // throws an error if the collection is empty
            var city = mycities.FirstOrDefault();
            Console.WriteLine(city);

            var lastcity = cities.Last();
            Console.WriteLine(lastcity);
            lastcity = mycities.LastOrDefault();
            Console.WriteLine(lastcity);
        }

        static void SingleFunc()
        {
            string[] s = { "Banurekha" };
            string[] s1 = { "Arun", "Ajay", "Ajith" };
            string[] s2 = { };
            var result = s.Single(); // works fine since there is only one element in the sequence
           //  result = s1.Single(); // throws more elements in sequence error
           // result = s2.Single(); // throws no elements in the sequence error
           // Console.WriteLine(result);

            var sres = s.SingleOrDefault(); // works fine
           // sres = s1.SingleOrDefault(); // throws error
          //  sres = s2.SingleOrDefault(); // no error, no display, default null 
            Console.WriteLine(sres);

        }
    }
}
