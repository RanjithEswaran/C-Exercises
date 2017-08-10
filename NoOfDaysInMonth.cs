using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoOfDaysInMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the Month Number");
            try
            {
                num = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("No of days");
                switch (num)
                {
                    case 1:
                        Console.WriteLine("31");
                        break;
                    case 2:
                        Console.WriteLine("Enter the year");
                        int year = Convert.ToInt16(Console.ReadLine());
                        if (year % 4 == 0)
                            Console.WriteLine("29");
                        else
                            Console.WriteLine("28");
                        break;
                    case 3:
                        Console.WriteLine("31");
                        break;
                    case 4:
                        Console.WriteLine("30");
                        break;
                    case 5:
                        Console.WriteLine("31");
                        break;
                    case 6:
                        Console.WriteLine("30");
                        break;
                    case 7:
                        Console.WriteLine("31");
                        break;
                    case 8:
                        Console.WriteLine("31");
                        break;
                    case 9:
                        Console.WriteLine("30");
                        break;
                    case 10:
                        Console.WriteLine("31");
                        break;
                    case 11:
                        Console.WriteLine("30");
                        break;
                    case 12:
                        Console.WriteLine("31");
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
