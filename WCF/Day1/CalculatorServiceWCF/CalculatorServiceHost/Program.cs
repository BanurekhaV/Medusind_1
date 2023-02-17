using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using(System.ServiceModel.ServiceHost host=
                new System.ServiceModel.ServiceHost(typeof(CalculatorServiceWCF.CalculatorService)))
            {
                host.Open();
                Console.WriteLine("Host Services Started @" + DateTime.Now.ToString());
                Console.Read();
            }
        }
    }
}
