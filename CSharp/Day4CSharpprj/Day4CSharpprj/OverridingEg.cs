using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4CSharpprj
{
    class Shape
    {
        protected float R, L=2, B=3;

        public virtual float Area()  //marking a function virtual ensures overriding
        {
            Console.WriteLine("I am Shape");
            return 3.14f * R * R;
        }

        public virtual float Circumference()
        {
            return 2 * 3.14f * R;
        }
    }

    class Rectangle : Shape
    {
        public void GetLB()
        {
            Console.Write("Enter Length :");
            L = float.Parse(Console.ReadLine());
            Console.Write("Enter Breadth :");
            B = float.Parse(Console.ReadLine());
        }

        public override float Area()
        {
            // return base.Area();
            Console.WriteLine("I am Rectangle");
            return L * B;
        }
        public override float Circumference()
        {
            // return base.Circumference();
            return 2 * (L + B);
        }
    }

    class Circle : Shape
    {
        public void GetRadius()
        {
            Console.Write("Enter Radius :");
            R = float.Parse(Console.ReadLine());
        }

        public override float Area()
        {
            Console.WriteLine("Hi I am Circle");
            return 3.14f * R * R;
        }

    }
    class OverridingEg
    {
        static void Main()
        {
            //Rectangle r = new Rectangle();
            //r.GetLB();
            //Console.WriteLine("Area :{0}", r.Area());
            //Console.WriteLine("Circunference : {0}", r.Circumference());
            //Console.WriteLine();

            //Circle c = new Circle();
            //c.GetRadius();
            //Console.WriteLine(c.Area());
            Console.WriteLine("------------Dynamic Polymorphisim-----------");
            Shape s = new Shape();
            Console.WriteLine(s.Area());
            s = new Circle();   //using co-variance concept
            Console.WriteLine(s.Area()); 
            s = new Rectangle();
            Console.WriteLine(s.Area()); 
            Console.ReadLine();
        }
    }
}

