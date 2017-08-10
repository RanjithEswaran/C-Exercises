using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrantIdentification
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Enter the X and Y coordinates");
            try
            {
                x = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());
                if (x == 0 && y == 0)
                    Console.WriteLine("The point is Origin");
                else if(x>0)
                {
                    if (y > 0)
                        Console.WriteLine("1st Quadrant");
                    else
                        Console.WriteLine("4th Quadrant");
                }
                else
                {
                    if (y > 0)
                        Console.WriteLine("2nd Quadrant");
                    else
                        Console.WriteLine("3rd Quadrant");
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
