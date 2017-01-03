using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            string rows;
            int rowsInt;
            string columns;
            int columnsInt;
            int[,] matrix;
            string value;
            int valueInt;

            //Introducimos el número de filas que tendrá la matriz
            Console.WriteLine("Input the number of Rows of the matrix: ");
            rows = Console.ReadLine();
            Int32.TryParse(rows, out rowsInt);

            //Introducimos el número de columnas que tendrá la matriz
            Console.WriteLine("Input the number of Columns of the matrix: ");
            columns = Console.ReadLine();
            Int32.TryParse(columns, out columnsInt);

            matrix = new int[rowsInt, columnsInt];

            //Pedimos por pantalla los valores de cada elemento de matriz[i,j]
            Console.WriteLine("\nInput the values of the Matrix");

            int zeros = 0; //Variable que almacenará la cantidad de 0 que se han introducido en la matriz
            for (int i=0; i<rowsInt; i++)
            {
                for (int j=0; j < columnsInt; j++)
                {
                    Console.WriteLine("Fila " + i + ", Columna " + j);
                    value = Console.ReadLine();
                    Int32.TryParse(value, out valueInt);
                    matrix[i, j] = valueInt;

                    if (valueInt == 0)
                    {
                        zeros = zeros + 1; //Sumamos 1 por cada 0 que se introduzca
                    }
                }
            }

            


            //Imprimimos por pantalla la Matriz
            for (int i = 0; i < rowsInt; i++)
            {
                for (int j = 0; j < columnsInt; j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\n\nThere are " + zeros + " zeros in the matrix");

            int Elements = (rowsInt * columnsInt) / 2; //Filas * columnas = Número de elementos que hay en la matriz. Si hay más de la mitad será "Sparse Matrix"
            if (zeros > Elements) //Comprobamos si hay más ceros que resto de números
            {
                Console.WriteLine("\nSPARSE MATRIX");   
            }else
            {
                Console.WriteLine("\n NOT SPARSE MATRIX");
            }

            Console.ReadLine();

        }
    }
}
