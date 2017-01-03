using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            int j = 0;
            int tamaño;
            string aux;
            string aux1;
            int numero;
            int[] numbers;
            int suma = 0;

            Console.WriteLine("Introduzca el tamaño del array: ");
            aux1 = Console.ReadLine();
            Int32.TryParse(aux1, out tamaño);

            numbers = new int[tamaño];

            for (i=0; i<numbers.Length; i++)
            {
                Console.WriteLine("introduzca el valor de la posición " + i + " del array");
                aux = Console.ReadLine();
                Int32.TryParse(aux, out numero);
                numbers[i] = numero;
            }

            for (i = 0; i < 3; i++)
            {
                //Console.WriteLine("Posicion" + i + " = " + numbers[i]);
                suma = suma + numbers[i];
                j = j + 1;
            }

            Console.WriteLine("La suma de los elementos del array es: " + suma);
            Console.WriteLine("El numero de posiciones del array es: " + j);
            

            Console.ReadLine();

        }
    }
}
