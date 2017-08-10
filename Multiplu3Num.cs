using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply3Num
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, product;
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());
            num3 = Convert.ToDouble(Console.ReadLine());
            product = num1 * num2 * num3;
            Console.WriteLine("Product is {0}", product);
            Console.ReadKey();
        }
    }
}
