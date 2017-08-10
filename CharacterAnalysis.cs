using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char ch;
                Console.WriteLine("Enter the Character");
                ch = Convert.ToChar(Console.ReadLine());
                if (ch >= 'a' && ch <= 'z')
                {
                    Console.WriteLine("You Entered a Character");
                }
                else if (ch >= '0' && ch <= '9')
                    Console.WriteLine("You Entered a digit");
                else if (!(ch >= 'A' && ch <= 'Z'))
                    Console.WriteLine("You Entered a symbol");
                else
                    throw new Exception();
            }
            catch(Exception e)
            {
                Console.WriteLine("You Enter a wrong input");
            }
            Console.ReadKey();
        }
    }
}
