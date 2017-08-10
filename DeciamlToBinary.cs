using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            try
            {
                Console.WriteLine("Enter the number");
                a = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Binary form ");
                int remainder,binary=0,i=1;
                while(a!=0)
                {
                    remainder = a % 2;
                    a = a / 2;
                    binary = binary + (remainder * i);
                    i*= 10;
                }
                Console.WriteLine("{0}", binary);
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();
        }
    }
}
