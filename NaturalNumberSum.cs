using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalNumberSum
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
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(i + " ");
                    sum += i;
                }
                Console.WriteLine("\nSum " + sum);
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();
        }
    }
}
