using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4CSharpprj
{
    abstract class Shapes
    {
        //declare non-abstract method with implementation
        public virtual void Message()
        {
            Console.WriteLine("Hi Welcome");
        }

        //declare abstract method without implementation
         public abstract int Area();
    }

    class Square : Shapes
    {
        int side = 0;

        //constructor
        public Square(int n)
        {
            side = n;
        }
        public override int Area()
        {
            return side * side;
        }

        public override void Message()
        {
            base.Message(); // parents message function
            Console.WriteLine("Message from Square");
        }

    }
    class abstracteg
    {
        static void Main()
        {
            Shapes s;
            s = new Square(6);
            Console.WriteLine("The Area of Square is {0}",s.Area());
            s.Message();
            Console.Read();
        }
    }

}
