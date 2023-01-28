using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4CSharpprj
{
    class ExceptionEg
    {
        static void Main()
        {
            int a, b, c;
            try
            {
                Console.WriteLine("enter 2 nos :");
                a = int.Parse(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                int[] arr = { 2, 4, 6, 8 };
                Console.WriteLine(arr[2]);
                Console.WriteLine(c);

            }           
            catch (FormatException fe)
            {
                //Console.WriteLine(fe.Message + fe.StackTrace+ fe.Source);
                Console.WriteLine("Please enter only numbers");
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("You cannot divide a number by Zero");
            }
            catch(IndexOutOfRangeException ie)
            {
                Console.WriteLine("Attempting to read values beyond array");
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops !! some error occurred. Try Later");
            }

            finally{
                Console.WriteLine("Reached Finally");
            }
            Console.Read();
        }
    }
}
