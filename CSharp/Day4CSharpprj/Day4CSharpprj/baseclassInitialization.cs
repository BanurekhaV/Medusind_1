using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4CSharpprj
{
    class Parent
    {
        public int data1;
        public Parent(int a)
        {
            data1 = a;
            Console.WriteLine("Parents Data is {0}",data1);
        }
    }

    class Child : Parent
    {
        public int data2;
        public Child(int b):base(b) //calling the parent constructor
        {
            data2 = b;
            Console.WriteLine("Childs Data is {0}",data2);
        }

        public Child(int x, int y):base(y)
        {
            data2 = x;
            Console.WriteLine("Childs Data {0}",data2);
        }
    }
    class baseclassInitialization
    {
        static void Main()
        {
          //  Parent p = new Parent(5);
            Child child= new Child(10);
            Child child1 = new Child(2, 8);
            Console.Read();
        }
    }
}
