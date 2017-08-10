using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt16(Console.ReadLine());
            for(int i=1;i<= 10;i++)
            {
                Console.WriteLine("{0} * {1} = {2}", i, n, i * n);
            }
            Console.ReadKey();
        }
    }
}
