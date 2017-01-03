using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string size;
            int sizeInt;
            int[] vector;
            string valor;
            int valorInt;
            //int resta;
            //int restaMenor;  
            int largest = Int32.MinValue;
            int secondLargest = Int32.MinValue;

            //Pedimos los valores por pantalla

            Console.WriteLine("Introduzca el número de elementos del Array:");
            size = Console.ReadLine();
            Int32.TryParse(size, out sizeInt);

            vector = new int[sizeInt];

            //for (int i= vector.Length -1 ; i>=0; i--)
            //{
            //    vector[i] = i;
            //}

            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Introduzca el valor de la posición " + i + " del Array");
                valor = Console.ReadLine();
                Int32.TryParse(valor, out valorInt);
                vector[i] = valorInt;
            }

            TimeSpan stop;
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);


            //Buscamos el mayor elemento del Array
            for (int i = 0; i < vector.Length; i++) 
            {
                if (vector[i] > largest)
                {
                    largest = vector[i];
                }
            }


            //Buscamos el segundo mas grande Obviando el anterior
            for (int i = 0; i < vector.Length; i++)
            {
                if ((vector[i] != largest) && (vector[i] > secondLargest))
                {
                    secondLargest = vector[i];
                }
            }

            //restaMenor = largest;

            //for (int i = 0; i < vector.Length; i++)
            //{
            //    resta = largest - vector[i];
            //    if ((resta < restaMenor) && (resta !=0))
            //    {
            //        restaMenor = resta;
            //        secondLargest = vector[i];
            //    }
            //}

            stop = new TimeSpan(DateTime.Now.Ticks);

            

            Console.WriteLine("El valor más grande del vector es: " + largest);
            Console.WriteLine("El segundo valor más grande del vector es: " + secondLargest);
            Console.WriteLine("El tiempo de ejecución ha sido: " +stop.Subtract(start).TotalMilliseconds);


            Console.ReadLine();
        }
    }
}
