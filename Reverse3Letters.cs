using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse3Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            Char[] str = new char[3];
            Console.WriteLine("Enter the three letters");
            try {
                for (int i = 0; i < 3; i++)
                    str[i] = Convert.ToChar(Console.ReadLine());
                str.Reverse();
                Console.WriteLine("The reversed string is ");
                for (int i = 2; i >= 0; i--)
                    Console.Write("{0}", str[i]);
            }
            catch(Exception e)
            {
                Console.WriteLine("Give Proper Input");
            }
            Console.ReadKey();
        }
    }
}
