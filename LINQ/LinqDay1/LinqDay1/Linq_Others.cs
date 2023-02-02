using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDay1
{
    class Linq_Others
    {
        static void Main()
        {
            //  Reverse();
            //Console.WriteLine("-------------");
            //ThenBy();
            //Console.WriteLine("----------");
            //Skip();
            //Console.WriteLine("------------");
            //SkipWhile();
            // TakeWhile();
            // GroupBy();
            SelectMany();
            Console.Read();
        }

        static void Reverse()
        {
            char[] chrs = { 'm', 'e', 'd', 'u', 's', 'i', 'n', 'd' };

            var result = chrs.Reverse();
            foreach(char c in result)
            {
                Console.WriteLine(c);
            }
        }

        static void ThenBy()
        {
            string[] vehicles = { "Car", "Z", "Truck", "Scooter", "Bike", "Auto", "Van", "Moped" };
                         //z, car,truck,bike,auto,van,moped,scooter
                         //z,car,bike,auto,van,truck,moped,scooter
                         //z,car,bike,van,auto,truck,moped,scooter
                         //z,car,van,bike,auto,truck,moped,scooter

            var sortedvehicles = vehicles.OrderBy(v => v.Length).ThenByDescending(x=>x);
            
            foreach(var v in sortedvehicles)
            {
                Console.WriteLine(v);
            }
        }

        static void Skip()
        {
            string[] colors = { "White", "Yellow", "Red", "Green", "Blue", "Purple" };
            var result = colors.Skip(2);
            foreach (var v in result)
            {
                Console.WriteLine(v);
            }
        }

        static void SkipWhile()
        {
            string[] countries = { "India", "Japan", "Malaysia", "Six", "Aa", "Korea","Bb", "Australia" };
             var result = countries.SkipWhile(x => x.Length >=5);
            
            foreach (var v in result)
            {
                Console.WriteLine(v);
            }
        }

        static void TakeWhile()
        {
            int[] numbers = { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = numbers.TakeWhile(x => x < 5);
            foreach (var v in result)
            {
                Console.WriteLine(v);
            }
        }

        static void GroupBy()
        {
            int[] numbers = { 10, 15, 20, 25, 30, 35, 40, 45, 50 };

            var result = numbers.GroupBy(a => (a % 10 == 0));
            Console.WriteLine("We have 2 Groups :");
            foreach(IGrouping<bool,int> g in result)
            {
                if (g.Key == true)
                {
                    Console.WriteLine("Divisible by 10");
                }
                else
                    Console.WriteLine("Not Divisible by 10");

                foreach(int n in g)
                {
                    Console.WriteLine(n);
                }
            }
        }

        static void SelectMany()
        {
            string[] countries = { "India", "Canada", "USA" };
            string[] capitals = { "Delhi", "Vanchover", "Washington" };

            var result = countries.SelectMany(c => capitals, (c, cp) => new
            {
                Countries = c,
                Capitals=cp
            }) ;

            foreach(var item in result)
            {
                Console.WriteLine(item.Countries + " "+ item.Capitals);
            }
        }
    }
} 
