using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        double resultado;
        double pi = Math.PI;

        public double perimeter(double value)
        {
            resultado = 2 * pi * value;
            return resultado;
        }

        public double area(double value)
        {
            resultado = pi * value * value;
            return resultado;
        }

        static void Main(string[] args)
        {
            string radius;
            double radiusDouble;
            double perimeter;
            double area;

            Program circle = new Program(); 

            Console.WriteLine("Input the radius of the circle: ");
            radius = Console.ReadLine();
            double.TryParse(radius, out radiusDouble);

            perimeter = circle.perimeter(radiusDouble);
            area = circle.area(radiusDouble);

            Console.WriteLine("\n PERIMETER: " + perimeter);
            Console.WriteLine("\n AREA: " + area);

            Console.ReadLine();

        }
    }
}
