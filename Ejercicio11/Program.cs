using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix;
            int sizeInt = 3;
            string valor;
            int valorInt;
            int primer;
            int segundo;
            int determinante;

            matrix = new int[sizeInt, sizeInt];

            Console.WriteLine("  Introduzca los valores de la matrix (3x3):"); //Introducimos valores para cada matrix[fila,columna]
            for (int i = 0; i < sizeInt; i++)
            {
                for (int j = 0; j < sizeInt; j++)
                {
                    Console.WriteLine("Fila " + i + ", Columna " + j);
                    valor = Console.ReadLine();
                    Int32.TryParse(valor, out valorInt);
                    matrix[i, j] = valorInt;
                }
            }

            Console.WriteLine("\n  The matrix is: \n");


            for (int i = 0; i < sizeInt; i++)  //Imprimimos por pantalla la matriz
            {
                for (int j = 0; j < sizeInt; j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
                Console.WriteLine("");
            }

            primer = ((matrix[0,0] * matrix[1,1] * matrix[2,2]) + (matrix[1,0] * matrix[2,1] * matrix[0, 2]) + (matrix[0,1] * matrix[1,2] * matrix[2,0]));
            segundo = ((matrix[2,0] * matrix[1,1] * matrix[0,2]) + (matrix[1,0] * matrix[0,1] * matrix[2,2]) + (matrix[0,0] * matrix[2,1] * matrix[1,2]));
            determinante = primer - segundo;

            Console.WriteLine("\nEl determinante de la matriz es: " + determinante);

            Console.ReadLine();
        }
    }
}
