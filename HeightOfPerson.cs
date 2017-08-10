using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightOfPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            int height;
            try
            {
                Console.WriteLine("Enter the height of the person");
                height = Convert.ToInt16(Console.ReadLine());
                if (height <= 0)
                    Console.WriteLine("You entered a wrong height");
                else if (height < 100)
                    Console.WriteLine("You are shorter");
                else if (height < 150)
                    Console.WriteLine("You are of medium height");
                else
                    Console.WriteLine("You are a tall person");
            }
            catch
            {
                Console.WriteLine("Invalid data");
            }
            Console.ReadKey();
        }
    }
}
