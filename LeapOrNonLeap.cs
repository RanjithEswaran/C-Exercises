using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapOrNonLeap
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the year:");
            try
            {
                year = Convert.ToInt16(Console.ReadLine());
                if (year >= 1000 && year <= 9999)
                {
                    if (year % 4 == 0)
                    {
                        if (year % 100 == 0)
                        {
                            if (year % 400 == 0)
                                Console.WriteLine("Leap Year");
                            else
                                Console.WriteLine("Not a Leap Year");
                        }
                        else
                            Console.WriteLine("Leap Year");
                    }
                    else
                        Console.WriteLine("Not a Leap Year");
                }
                else
                    throw new Exception();
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
