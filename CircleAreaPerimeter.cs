using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, area, perimeter;
            try
            {
                Console.WriteLine("Enter the radius of the circle");
                radius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area : {0}sq.units\nPerimeter : {1}", 3.14 * radius * radius, 2 * 3.14 * radius);
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("Provide valid input");
                Console.ReadKey();
            }
        }
    }
}
