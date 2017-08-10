using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultAbbreviation
{
    class Program
    {
        static void Main(string[] args)
        {
            char grade;
            try
            {
                Console.WriteLine("Enter the grade");
                grade = Convert.ToChar(Console.ReadLine());
                switch(grade)
                {
                    case 'E':
                        Console.WriteLine("Excellent");
                        break;
                    case 'V':
                        Console.WriteLine("Very good");
                        break;
                    case 'G':
                        Console.WriteLine("Good");
                        break;
                    case 'A':
                        Console.WriteLine("Average");
                        break;
                    case 'F':
                        Console.WriteLine("Fail");
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Wrong Data");
            }
            Console.ReadKey();

        }
    }
}
