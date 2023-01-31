using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Others
{
    public delegate void Multidel();
    public delegate int Multidel2(int a);
    class MulticastDelegate
    {
        public static void Method1()
        {
            Console.WriteLine("Method 1");
        }

        public static void Method2()
        {
            Console.WriteLine("Method 2");
        }

        public static void Method3()
        {
            Console.WriteLine("Method 3");
        }

        static void Main()
        {
            //multicast 1st option
            Multidel m1, m2, m3, m4;
            m1 = new Multidel(Method1);
            m2 = new Multidel(Method2);
            m3 = new Multidel(Method3);
            m4 = m1 + m2 + m3;  //or
            //m1 += m2;
            //m1 += m3;
            //m4 = m1;
            //m4();
            //m4 = m1 + m2 - m3;
            //m4();
            //Console.WriteLine("----------------");
            ////2nd option
            //Multidel m = new Multidel(Method1);
            //m += Method2;
            //m += Method3;
            //m();
            //m -= Method2;
            //m();
            //multicasting of delegates with return values
            Multicast2 multi2 = new Multicast2();
            Multidel2 mdel2 = new Multidel2(multi2.Triplets);
            mdel2 += multi2.Square;
            int retval = mdel2(5);
            Console.WriteLine(retval);
            Console.Read();
        }
    }

    class Multicast2
    {
        static int n;
        public int Square(int x)
        {
            n = x * x;
            return n;
        }

        public int Triplets(int q)
        {
            n = q * q * q;
            return n;
        }
    }
}
