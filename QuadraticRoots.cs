using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticRoots
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, m, root1,root2;
            try
            {
                Console.WriteLine("Enter a");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter b");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter c");
                c = Convert.ToDouble(Console.ReadLine());
                m = Math.Sqrt(b * b - (4 * a * c));
                root1 = (-b + m )/ (2 * a);
                root2 = (-b - m) / (2 * a);
                Console.WriteLine("Root1 : {0} \nRoot2 : {1}", root1, root2);
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();
        }
    }
}
