using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSides
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1, side2, side3;
            Console.WriteLine("Enter the three Sides of the triangle");
            try
            {
                side1 = Convert.ToDouble(Console.ReadLine());
                side2 = Convert.ToDouble(Console.ReadLine());
                side3 = Convert.ToDouble(Console.ReadLine());
                if (side1 == side2 && side1 == side3)
                    Console.WriteLine("Equilateral Triangle");
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                    Console.WriteLine("Isosceles Triangle");
                else
                    Console.WriteLine("Scalene Triangle");
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();
        }
    }
}
