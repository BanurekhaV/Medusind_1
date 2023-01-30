using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4CSharpprj
{
    class VotingException : ApplicationException
    {
        public VotingException(string msg) : base(msg) //invoking the base class constructor thru the derived class constructor
        {

        }
    }

    class Vote
    {
        int age;
        public void AcceptAge()
        {
            Console.WriteLine("Enter Your Age :");
            age = Convert.ToInt32(Console.ReadLine());
            if(age<18)
            {
                throw (new VotingException("Age should be greater than 18 to Vote.."));
            }
            else
            {
                Console.WriteLine("Thanks for Voting....");
            }
        }
    }
    class UserDefinedException
    {
        static void Main()
        {
            Vote vote = new Vote();
            try
            {
                vote.AcceptAge();
            }
            catch(VotingException ve)
            {
                Console.WriteLine(ve.Message);
            }
            Console.Read();
        }
    }
}
