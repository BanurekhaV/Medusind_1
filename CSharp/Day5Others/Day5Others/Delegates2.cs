using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Others
{
    delegate int NumberChanger(int n);
    class Delegates2
    {
        static int num = 0;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultiplyNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        static void Main()
        {
            //create instances of the delegate type
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultiplyNum);

            //call the delegates
            nc1(25);
            Console.WriteLine("Value of Num :{0}", getNum());
            nc2(5);
            Console.WriteLine("Value of Num :{0}", getNum());
            Console.Read();
        }
    }
}
