using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ExceptionServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host=new ServiceHost
                (typeof(ExceptionService.MathsService)))
            {
                host.Open();
                Console.WriteLine("Server Started.....");
                Console.Read();
            }
        }
    }
}
