using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrConsonant
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter the character");
            try
            {
                ch = Convert.ToChar(Console.ReadLine());
                if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
                    Console.WriteLine("Vowel");
                else
                    Console.WriteLine("Consonant");
            }
            catch
            {
                Console.WriteLine("Invalid data");
            }
            Console.ReadKey();
        }
    }
}
