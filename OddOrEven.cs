using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            try
            {
                Console.WriteLine("Enter the number");
                num = Convert.ToInt16(Console.ReadLine());
                if (num % 2 == 0)
                    Console.WriteLine("Even");
                else
                    Console.WriteLine("Odd");
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
