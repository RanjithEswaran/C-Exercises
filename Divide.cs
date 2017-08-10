using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, remainder;
            int quotient;
            Console.WriteLine("Enter the numbers");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            quotient = Convert.ToInt32(a/b);
            remainder = a % b;
            Console.WriteLine("Q = " + quotient + " R = " + remainder);
            Console.ReadLine();

        }
    }
}
