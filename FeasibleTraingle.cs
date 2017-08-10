using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeasibleTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int deg1, deg2, deg3;
            Console.WriteLine("Enter the three angles in the triangle");
            try
            {
                deg1 = Convert.ToInt16(Console.ReadLine());
                deg2 = Convert.ToInt16(Console.ReadLine());
                deg3 = Convert.ToInt16(Console.ReadLine());
                if (deg1 + deg2 + deg3 == 180)
                    Console.WriteLine("Triangle is possible");
                else
                    Console.WriteLine("Triangle is not possible");
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();
        }
    }
}
