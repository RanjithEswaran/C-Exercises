using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter the integer");
            try
            {
                x = Convert.ToInt16(Console.ReadLine());
                if (x > 0)
                    Console.WriteLine("1");
                else if (x < 0)
                    Console.WriteLine("-1");
                else
                    Console.WriteLine("0");
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
