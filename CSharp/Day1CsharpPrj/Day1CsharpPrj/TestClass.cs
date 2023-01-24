using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1CsharpPrj
{
    class TestClass
    {
        public void GetData()
        {
            Console.WriteLine("Please Enter Your First Name:");
            string Uname = Console.ReadLine();
            Console.WriteLine("Your Name is :" + Uname); //concatenation
            Console.WriteLine("Your Name is :{0}" ,Uname); //Placeholders

            //to show multiple place holders
            Console.WriteLine("Enter Your LastName :");
            string Lname = Console.ReadLine();
            Console.WriteLine("Your First Name is :{0} and your Last Name is :{1}", Uname,Lname);
            // using string interpolation
            Console.WriteLine($"Your FirstName is {Uname} and your LastName is {Lname}");
        }
    }
    
}
