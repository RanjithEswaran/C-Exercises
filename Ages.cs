using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int k;
            do
            {
                Console.WriteLine("Enter the age");
                try
                {
                    age = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("You look older than {0}", age);
                    k = 1;
                }
                catch (Exception e)
                {
                    k = 0;
                    Console.WriteLine("Enter in correct format");
                }
            } while (k != 1);
            Console.ReadKey();
        }
    }
}
