using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Others
{
    delegate T GenericDelegate<T>(T arg);  // decl a generic delegate

    class Utility
    {
        public static void GenericFunction<T>(T[] values, GenericDelegate<T> gd)
        {
            for(int i=0; i<values.Length; i++)
            {
                values[i] = gd(values[i]); // invoking the delegate
            }
        }
    }
    class GenericDelegates
    {
        static void Main()
        {
            // int[] v = new int[] { 4, 5, 6 };
            float[] v = new float[] { 4.4f, 5.5f };
            Utility.GenericFunction(v, Square); //square with integer argument is called
            foreach(var i in v)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }

        public static int Square(int x)
        {
            return x * x;
        }

        public static float Square(float x)
        {
            return x * x;
        }
    }
}
