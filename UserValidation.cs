using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string passWord;
            int flag = 0, count = 0;
            try
            {
                do
                {
                    Console.WriteLine("Enter Username");
                    userName = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter Password");
                    passWord = Convert.ToString(Console.ReadLine());
                    if (userName.Equals(passWord) == true)
                    {
                        flag = 1;
                        break;
                    }
                    else
                    {
                        count++;
                        Console.WriteLine("You have {0} attempts left", 3 - count);
                    }
                } while (count < 3 );
                if (flag == 1)
                    Console.WriteLine("Welcome");
                else
                    Console.WriteLine("Login Later");
            }
            catch(Exception e)
            {
                Console.WriteLine("Enter Correct input");
            }
            Console.ReadKey();
        }
    }
}
