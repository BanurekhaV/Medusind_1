using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3CSharpPrj
{
    class OveloadingEg
    {
       public void swap(int number1, int number2)
        {
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.WriteLine("Swapped Numbers are:" + number1 +" " +number2 );
        }
       public void swap(char char1, char char2)
        {
            char temp = ' ';
            temp = char1;
            char1 = char2;
            char2 = temp;
            Console.WriteLine("Character Swapping {0}, {1}",char1,char2 );
        }

        static void Main()
        {
            //OveloadingEg ol = new OveloadingEg();
            //ol.swap(5, 2);
            //ol.swap('a', 'z');
            Distance d1 = new Distance();
            d1.miles = 100;
            Distance d2 = new Distance();
            d2.miles = 200;
            Distance d3 = new Distance();
            d3 = d1 + d2;
            Console.WriteLine("The total distance is :{0}",d3.miles);
            Console.Read();
        }
    }

    class Distance
    {
        public int miles;
        public int km;

        //operator overloading
        public static Distance operator +(Distance dist1, Distance dist2)
        {
            Distance temp = new Distance();
            temp.miles = dist1.miles + dist2.miles;
            return temp; 
        }
    }
}
