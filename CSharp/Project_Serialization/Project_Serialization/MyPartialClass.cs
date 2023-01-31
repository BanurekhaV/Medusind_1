using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Serialization
{
    public partial class MyPartialClass
    {
        //lets have only method decl

        //method 1 - partial method
        partial void partialMethod(int data);

        //method 2 - normal method
        public void Show()
        {
            Console.WriteLine("Partial Methods");
        }

        static void Main()
        {
            MyPartialClass mpc = new MyPartialClass();
            mpc.newpartialMethod(20);
            mpc.Show();
            Console.Read();

        }
    }
}
