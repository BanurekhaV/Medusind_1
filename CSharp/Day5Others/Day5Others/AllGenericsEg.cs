using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Others
{
    //generic class
    class MyGenericClass<T>  //where T:struct (value types) or T: class (reference types)
    {
        //generic field
        private T genericfield;

        //generic constructor
        public MyGenericClass(T value)
        {
            genericfield = value;
        }
        //generic property
        public T genericproperty { get; set; }
        //generic method
        public T genericmethod(T genericparameter)
        {
            Console.WriteLine("Parameter Type is :{0}, value is :{1}", typeof(T).ToString(),genericparameter);
            Console.WriteLine("Return Type is {0}, valuee is :{1}", typeof(T).ToString(),genericfield);
            return genericfield;
        }
    }
    class AllGenericsEg
    {
        static void Main()
        {
            MyGenericClass<int> intgeneric = new MyGenericClass<int>(10);
            int retval = intgeneric.genericmethod(200);
            Console.WriteLine("Return Value is {0}",retval);
            Console.WriteLine(intgeneric.genericproperty);
            intgeneric.genericproperty = 50;
            Console.WriteLine(intgeneric.genericproperty);

            //2 nd instance of the generic class

            MyGenericClass<string> strgeneric = new MyGenericClass<string>("Constructor");
            string s = strgeneric.genericmethod("Welcome to Generics");
            Console.Read();
        }
    }
}
