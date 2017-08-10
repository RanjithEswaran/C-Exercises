using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveOrNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            try
            {
                Console.WriteLine("Enter the number");
                num = Convert.ToDouble(Console.ReadLine());
                if (num < 0)
                    Console.WriteLine("Negative");
                else if (num > 0)
                    Console.WriteLine("Positive");
                else
                    Console.WriteLine("No sign");
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
