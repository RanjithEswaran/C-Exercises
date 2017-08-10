using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Enter the three Numbers");
            try
            {
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
                if (a > b && a > c)
                    Console.WriteLine("{0} is the largest element", a);
                else if(b>c)
                    Console.WriteLine("{0} is the largest element", b);
                else
                    Console.WriteLine("{0} is the largest element", c);
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
