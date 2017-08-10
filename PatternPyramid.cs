using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            try
            {
                Console.WriteLine("Enter the number of rows");
                n = Convert.ToInt16(Console.ReadLine());
                for(int i=1;i<= n;i++)
                {
                    for (int k = n; k >= i; k--)
                        Console.Write(" ");
                    for (int j = 1; j <= i; j++)
                        Console.Write(i + " ");
                    Console.WriteLine();
                }
               
            }
            catch
            {
                Console.WriteLine("Invalid Input");

            }
            Console.ReadKey();
        }
    }
}
