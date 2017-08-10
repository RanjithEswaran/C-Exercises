using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[4];
            int i = 0;
            double sum = 0;
            Console.WriteLine("Enter the numbers");
            for(i=0;i<4;i++)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
                sum += a[i];
            }
            Console.WriteLine("Average = {0}", sum / 4);
            Console.ReadKey();

        }
    }
}
