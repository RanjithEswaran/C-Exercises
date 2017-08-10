using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElecticityBill
{
    class Program
    {
        static void Main(string[] args)
        {
            int units, cusId;
            string ch,name;
            double cost=20.00;
            do
            {
                Console.WriteLine("Enter the customer id");
                cusId = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter the customer name");
                name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the units Consmed");
                units = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Amunt to be paid is " + units * cost);
                Console.WriteLine("Do you want to continue");
                ch = Console.ReadLine();
            } while (ch.Equals("Yes") == true);

            Console.ReadKey(); 
        }
    }
}
