using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperature;
            Console.WriteLine("Enter the temperature");
            try
            {
                temperature = Convert.ToDouble(Console.ReadLine());
                if (temperature < 0)
                    Console.WriteLine("Freezing");
                else if (temperature < 10)
                    Console.WriteLine("Very Cold Weather");
                else if (temperature < 20)
                    Console.WriteLine("Cold Weather");
                else if (temperature < 30)
                    Console.WriteLine("Normal Temperature");
                else if (temperature < 40)
                    Console.WriteLine("Hot");
                else 
                    Console.WriteLine("Very Hot");
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadKey();
        }
    }
}
