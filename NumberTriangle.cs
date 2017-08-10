using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, width;
            try {
                num = Convert.ToInt16(Console.ReadLine());
                width = Convert.ToInt16(Console.ReadLine());
                for(int i=0;i< width;i++)
                {
                    for (int k = width; k > i; k--)
                        Console.Write(" ");
                    for (int j = 0; j <= i; j++)
                        Console.Write("{0} ", num);
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter input in Correct Format");
                Console.ReadKey();
            }
        }
    }
}
