using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Enter the two elements");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a = " + a + " b = " + b);
            Console.ReadKey();
        }
    }
}
