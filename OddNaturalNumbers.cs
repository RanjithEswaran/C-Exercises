using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c = 1;
            try {
                Console.WriteLine("Enter the range");
                n = Convert.ToInt16(Console.ReadLine());
                for (int i = 1; i <= n; i++) {
                    Console.Write(c + " ");
                    c += 2;
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
