using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            double num1, num2;
            Console.WriteLine("Enter num1");
            num1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1.Add 2.Subtract 3.Multiply 4.Divide");
            choice = Convert.ToInt16(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Sum {0}", num1 + num2);
                    break;
                case 2:
                    Console.WriteLine("Difference {0}", num1 - num2);
                    break;
                case 3:
                    Console.WriteLine("Product {0}", num1 * num2);
                    break;
                case 4:
                    Console.WriteLine("Quotient {0} Remainder {1}", num1 / num2,num1%num2);
                    break;

            }
            Console.ReadKey();
        }
    }
}
