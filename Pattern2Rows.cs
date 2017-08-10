using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern2Rows
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt16(Console.ReadLine());
            for(int i=0;i<2;i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write("{0} ", n);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
