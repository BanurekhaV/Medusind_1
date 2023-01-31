using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Serialization
{
    public partial class MyPartialClass
    {
        //method 3 - normal method
        public void newpartialMethod(int a)
        {
            partialMethod(a); //calling a partial method
        }

        partial void partialMethod(int data)
        {
            int answer = data + 100;
            Console.WriteLine(answer);
        }
    }
}
