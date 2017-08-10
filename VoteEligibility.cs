using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoteEligibility
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            try
            {
                Console.WriteLine("Enter the age");
                age=Convert.ToInt16(Console.ReadLine());
                if (age >= 18)
                    Console.WriteLine("You are elegible to vote");
                else if (age <=  0)
                    throw new Exception();
                else
                    Console.WriteLine("You are not elegible to vote");
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
