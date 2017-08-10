using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SphereMeasures
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                double radius;
                Console.WriteLine("Enter the radius of the sphere");
                radius = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Volume of the sphere is {0} cubic units ", (4 / 3) * 3.14 * radius * radius * radius);
                Console.WriteLine("Surface area of the sphere is {0} sq.units", 4 * 3.14 * radius * radius);
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid input"+e);
            }
            Console.ReadKey();
        }
    }
}
