using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            string choice;
            try
            {
                do
                {
                    Console.WriteLine("Enter your choice \n1.Square\n2.Rectangle\n3.Triangle\n4.Circle");
                    ch = Convert.ToInt16(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            int side;
                            Console.WriteLine("Enter the side of square");
                            side = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Area of square "+ side * side);
                            break;
                        case 2:
                            int side1,side2;
                            Console.WriteLine("Enter the sides of retangle");
                            Console.WriteLine("Enter the Length of retangle");
                            side1 = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Enter the breadth of retangle");
                            side2 = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Area of the Rectangle " + side1 * side2);
                            break;
                        case 3:
                            Console.WriteLine("Enter the Measures of triangle");
                            Console.WriteLine("Enter the base of triangle");
                            side1 = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Enter the height of triangle");
                            side2 = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Area of the triangle " + (0.5) *side1 * side2);
                            break;
                        case 4:
                            Console.WriteLine("Enter the sides of circle");
                            Console.WriteLine("Enter the radius of Circle");
                            side2
                                = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Area of the circle " + 3.14 * side2*side2);
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("Do you want to continue ? Yes/No");
                    choice = Console.ReadLine();
                } while (choice.Equals("Yes") == true);
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();
        }
    }
}
