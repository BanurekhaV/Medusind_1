using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4CSharpprj
{
    interface ICustomer //I prefixed to know it is an interface
    {
         void print(); //only decl.
        string show(string s);
    }

    interface ISupplier
    {
        void Display();
    }

    interface ICombo:ICustomer,ISupplier
    {
        void ComboFunc();
    }
    class Customer:ICombo
    {
        public void ComboFunc()
        {
            
        }

        public void Display()
        {
            
        }

        public void print()
        {
            Console.WriteLine("Interface Customers Method..");
        }

        public string show(string uname)
        {
            return "Hello" + uname;
        }

       
    }

    class TestInterface
    {
        static void Main()
        {
            
            Customer cust = new Customer();
            cust.print();
            // cust.ComboFunc();
            ICombo ic;
            ic = new Customer();
            ic.print();
            Console.Read();
        }
    }
}
