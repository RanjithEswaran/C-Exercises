using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAndAverageOf10Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int sum = 0;
            try
            {
                Console.WriteLine("Enter the numbers");
                for (int i = 0; i < 10; i++)
                {
                    arr[i] = Convert.ToInt16(Console.ReadLine());
                    sum =sum + arr[i];
                }
                Console.WriteLine("Sum {0} Average {1}", sum , sum/10);
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();
        }
    }
}
