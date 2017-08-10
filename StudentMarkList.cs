using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarkList
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            Console.WriteLine("Enter the number of students");
            try {
                n = Convert.ToInt16(Console.ReadLine());
                int[] roll = new int[n];
                int[] mark1 = new int[n];
                int[] mark2 = new int[n];
                int[] mark3 = new int[n];
                string[] name = new string[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter the Roll number");
                    roll[i] = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter the Name");
                    name[i] = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the Mark1");
                    mark1[i] = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter the Mark2");
                    mark2[i] = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter the Mark3");
                    mark3[i] = Convert.ToInt16(Console.ReadLine());
                }
                Console.WriteLine("Student Details\n");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Student " + i + 1);
                    Console.WriteLine("Roll Number : {0}\nName : {5}\nMark1 : {1}\nMark2 : {2}\nMark3 : {3}\nTotal : {4}\nPercentage : {6}%"
                        , roll[i], mark1[i], mark2[i], mark3[i], mark1[i] + mark2[i] + mark3[i],name[i], (mark1[i] + mark2[i] + mark3[i])/3);
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("invalid");
            }
            Console.ReadKey();
        }
    }
}
