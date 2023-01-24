using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2CSharpPrj
{
    class OtherEg
    {
        public static void Main()
        {
            int x;  // 4 bytes of memeory is allocated by the compiler
            char c;  // 1 byte of memory is allocated by compiler
            Sample s1 = new Sample();  // 4 bytes generally is allocated by the compiler
            s1.evennos(0);
            //Console.WriteLine("");
            //Sample s2 = new Sample();

            //s2.evennos(2);
            s1.single_d_arrayeg();
            Console.ReadKey();
        }
        static void Nullablexample()
        {
            //nullable concept

            int? TicketsonSale = null; //nullable value type
            int Availabletickets; //non-nullable value type
            if (TicketsonSale == null)
            {
                Availabletickets = 0;
            }
            else
            {
                //Availabletickets = (int)TicketsonSale; //or
                Availabletickets = TicketsonSale.Value;
            }
            Console.WriteLine("Available Tickets ={0}", Availabletickets);
            Console.WriteLine("*******************");
            //the above code can be replaced with null coalescing operator ??

            Availabletickets = TicketsonSale ?? 0;
            Console.WriteLine(Availabletickets);
        }
    }

    class Sample
    {
        public static void testfunction() //class function
        {
            Console.WriteLine("Test Function");
        }

        public void evennos(int num) // instance method/function
        {
            int i = 1; // counter intialization
            while(i<=num) // condition check
            {
                Console.WriteLine(i);
                i += 2; //change of counter value
            }
            Console.WriteLine("-------do loop------");
            do
            {
                Console.WriteLine(i);
                i += 2;
            } while (i <= num);

            Console.WriteLine("-------for loop-------");
            for(;i<=num; i+=2)
            {
                Console.WriteLine(i);
            }
        }

        public void single_d_arrayeg()
        {
            int[] arr = new int[5];
            for(int i=0; i<5;i++)
            {
                Console.WriteLine("Give values for the array");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            System.Array.Reverse(arr);
            Console.WriteLine("============");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Values of the array are :");
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine(arr.Length);
           
        }

        public void multi_d_arrayeg()
        {
            int[,] arr1 = new int[2, 2] { { 12, 32 }, { 34, 54 } };
        }

        public void jagged_arrayeg()
        {
            int[][] arr2 = new int[3][];
            arr2[0] = new int[] { 1, 2, 3 };
            arr2[1] = new int[] { 4, 5, 6, 7 };
            arr2[2] = new int[] { 8, 9 };
        }
    }
}
