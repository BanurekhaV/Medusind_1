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
            //nullable concept

            int ? TicketsonSale =null; //nullable value type
            int Availabletickets; //non-nullable value type
            if(TicketsonSale==null)
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
            Console.ReadKey();
        }
    }

    class Sample
    {
        public void testfunction()
        {
            Console.WriteLine("Test Function");
        }
    }
}
