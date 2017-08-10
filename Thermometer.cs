using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thermometer
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius;
            Console.WriteLine("Enter the temperature in celcius");
            celcius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Fahrenheit : {0}F \nKelvin : {1}K",celcius*5/9+32,celcius+273.5);
            Console.ReadKey();
        }
    }
}
