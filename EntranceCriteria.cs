using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntranceCriteria
{
    class Program
    {
        static void Main(string[] args)
        {
            int phy, chem, maths, total;
            try
            {
                Console.WriteLine("Enter your Physics mark");
                phy = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter your Chemistry mark");
                chem = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter your Maths mark");
                maths = Convert.ToInt16(Console.ReadLine());
                total = phy + chem + maths;
                if (maths >= 60 && phy >= 55 && chem >= 50)
                    Console.WriteLine("Elegible");
                else
                    Console.WriteLine("Not Elegible");
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();
        }
    }
}
