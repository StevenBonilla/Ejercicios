using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            int valueInt;
            int[] binary;
            int resto;
            int i = 0;

            Console.WriteLine("\nInput  the number to convert into binary: "); //Pedimos el número a transformar por pantalla
            value = Console.ReadLine();
            Int32.TryParse(value, out valueInt);

            binary = new int[1]; //Creamos un vector inicialmente de tamaño 1, pero que irá aumentando.

            do
            {
                resto = valueInt % 2; //calculamos el resto, que siempre será 0 o 1
                valueInt = valueInt / 2; //El cociente será el siguiente valor a analizar
                
                binary[i] = resto; //Vamos introduciendo en cada posición del vector el valor obtenido en el resto (0 o 1)

                Array.Resize(ref binary, binary.Length + 1); //Nos permite ir aumentando el tamaño del vector. En la última iteración se almacenará un 0 en la última posición, rellenamos más adelante
                i = i + 1; //Corresponde al puntero que indicará en que posición del vector nos econtramos

            } while (valueInt > 1); //El último de los cocientes será 1, por lo que cuando lleguemos ahí, salimos del bucle

            binary[i] = valueInt; //Metemos en la última posición del vector el último valor obtenido de "valueInt", que siempre será 1

            Console.WriteLine("\n *** Binary *** \n");  
            for (int j = binary.Length - 1; j >= 0; j--) //Leemos de forma inversa el vector, para que salga ordenado el número en binario
            { 
                Console.Write(binary[j]);
            }

            Console.ReadLine();

        }
    }
}
