using System;

namespace Day1CsharpPrj
{
    class Program
    {
        //int var1;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello All !! Welcome to CSharp..");
            Program.myFunc(); // static function qualified with the classname
            myFunc(); // static function call within the class
            Program p = new Program(); // objects
           // p.var1 = 10;
           // int x; //variables
           // x = 5;
            string result=p.Message();
            Console.WriteLine(result);
            //// p.myFunc(); cannot refer static function with the object
            Console.WriteLine("--------Other Class Function");
            TestClass testclass = new TestClass();
            testclass.GetData();
            Console.Read();
        }

        static void myFunc()
        {
            Console.WriteLine("This is myFunc()");
        }

        public string Message()
        {
            return "Hello";
        }
    }

    
}
