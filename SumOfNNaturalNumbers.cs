using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            try
            {
                Console.WriteLine("Enter the range");
                n = Convert.ToInt16(Console.ReadLine());
                sum = n * (n + 1) / 2;
                Console.WriteLine("Sum of {0} natural numbers is {1}", n, sum);
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();
        }
    }
}
