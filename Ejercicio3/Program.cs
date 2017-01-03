using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            int numberInt;
            int multiplicacion;
            int i;

            Console.WriteLine("Introduzca el numero");
            number = Console.ReadLine();

            bool correct = Int32.TryParse(number, out numberInt);

            Console.WriteLine("Solucion");

            for (i=0; i<=10; i++)
            {
                multiplicacion = numberInt * i;
                Console.WriteLine(numberInt + "*" + i + " = " +multiplicacion.ToString());
            }

            Console.ReadLine();
        }
    }
}
