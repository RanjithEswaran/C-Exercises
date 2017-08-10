using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitOrLoss
{
    class Program
    {
        static void Main(string[] args)
        {
            double costPrize, sellingPrize;
            try
            {
                Console.WriteLine("Enter the cost and selling prize");
                costPrize = Convert.ToDouble(Console.ReadLine());
                sellingPrize = Convert.ToDouble(Console.ReadLine());
                if (costPrize > sellingPrize)
                    Console.WriteLine("Loss Rs " + (costPrize - sellingPrize));
                else if (sellingPrize > costPrize)
                    Console.WriteLine("Profit Rs " + (sellingPrize - costPrize));
                else
                    Console.WriteLine("NO LOSS NO GAIN");
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();
        }
    }
}
