using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayNumberName
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the day Number");
            try
            {
                num = Convert.ToInt16(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Sunday");
                        break;
                    case 2:
                        Console.WriteLine("Monday");
                        break;
                    case 3:
                        Console.WriteLine("Tuesday");
                        break;
                    case 4:
                        Console.WriteLine("Wednesday");
                        break;
                    case 5:
                        Console.WriteLine("Thursday");
                        break;
                    case 6:
                        Console.WriteLine("Friday");
                        break;
                    case 7:
                        Console.WriteLine("Saturday");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadKey();
        }
    }
}

