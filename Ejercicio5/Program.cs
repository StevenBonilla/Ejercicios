using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            float Kelvin;
            float Fahrenheit;
            float celsiusFloat;


            Console.WriteLine("Introduzca la temperatura en Celsius: ");
             string celsius = Console.ReadLine();

            //from string to float
            celsiusFloat = float.Parse(celsius);

            Fahrenheit = ((celsiusFloat * 9) / 5) + 32;
            Kelvin = celsiusFloat + 273;

            Console.WriteLine("Float: " + celsiusFloat);
            Console.WriteLine("Fahrenheit: " + Fahrenheit);
            Console.WriteLine("Kelvin: " + Kelvin);

            Console.ReadLine();
        }
    }
}
