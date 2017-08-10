using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            try
            {
                Console.WriteLine("Enter the two numbers");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                if (a == b)
                    Console.WriteLine("They are equal");
                else 
                    Console.WriteLine("They are not equal");
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();
        }
    }
}
