using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllOddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            long a, b;
            int count1 = 0,count2 = 0;

            
                Console.WriteLine("Enter the two numbers");
                try {
                    a = Convert.ToInt64(Console.ReadLine());
                    b = Convert.ToInt64(Console.ReadLine());
                    if (a % 2 == 0)
                        count1++;
                    if (b % 2 == 0)
                        count1++;
                    if (a % 2 != 0)
                        count2++;
                    if (b % 2 != 0)
                        count2++;
                    if (count1 == 2 || count2 == 2)
                        Console.WriteLine("True");
                    else
                        Console.WriteLine("False");
                }
                catch(Exception e)
                {
                    Console.WriteLine("Invalid input");
                }
                Console.ReadKey();
                    

      
        }
    }
}
