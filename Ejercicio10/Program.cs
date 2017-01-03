using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix;
            string size;
            int sizeInt;
            string valor;
            int valorInt;


            Console.WriteLine("Introduzca el tamaño de la matriz (regular)"); //Tamaño de la matriz
            size = Console.ReadLine();
            Int32.TryParse(size, out sizeInt);

            matrix = new int[sizeInt, sizeInt];

            Console.WriteLine("  Introduzca los valores de la matrix:"); //Introducimos valores para cada matrix[fila,columna]
            for (int i = 0; i < sizeInt; i++)
            {
                for (int j=0; j < sizeInt; j++)
                {
                    Console.WriteLine("Linea " + i + ", Columna " + j);
                    valor = Console.ReadLine();
                    Int32.TryParse(valor, out valorInt);
                    matrix[i, j] = valorInt;
                }
            }

            Console.WriteLine("\n  The matrix is: \n");


            for (int i=0; i < sizeInt; i++)  //Imprimimos por pantalla la matriz
            {
                for (int j = 0; j < sizeInt; j++)
                {
                    Console.Write(" " + matrix[i,j]);
                }
                Console.WriteLine("");
            }

            int suma = 0; //Inicializamos el valor "suma" a 0
            int[] diagonal = new int[sizeInt];

            for (int i = 0; i < sizeInt; i++) 
            {
                suma = suma + matrix[i, i]; //vamos sumando cada valor de la diagonal matrix[0,0] + matrix[1,1] + matrix[2,2] 
                diagonal[i] = matrix[i, i];
            }

            Console.WriteLine("\nAddition of the Main diagonal element is: " + suma);
            Console.WriteLine("\nElements in array (diagonal) are: ");

            for (int i = 0; i < sizeInt; i++)
            {
                Console.Write(" " + matrix[i,i]);
            }

            Console.ReadLine();

        }
    }
}
