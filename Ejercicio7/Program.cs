﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            string tamaño;
            int tamañoInt;
            string valor;
            int valorInt;
            int[] vector;
            int repetido = 0;
            int i;
            int j;

            Console.WriteLine("Introduzca el número de elementos del Array:");
            tamaño = Console.ReadLine();
            Int32.TryParse(tamaño, out tamañoInt);

            vector = new int[tamañoInt];

            for (i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Introduzca el valor de la posición " + i + " del Array");
                valor = Console.ReadLine();
                Int32.TryParse(valor, out valorInt);
                vector[i] = valorInt;
            }

            for (i = 0; i < vector.Length; i++)
            {
                for (j = i + 1; j < vector.Length; j++)
                {
                    if (vector[i] == vector[j])
                    {
                        repetido = repetido + 1;
                        break;
                    }
                }
            }

            Console.WriteLine("El tamaño del vector es: " + tamaño);
            Console.WriteLine("Elementos duplicados: " + repetido);

            Console.ReadLine();





        }
    }
}

//using System;  
//public class Exercise5
//{
//    public static void Main()
//    {

//        int[] arr1 = new int[100];
//        int i, j, n, ctr = 0;


//        Console.Write("\n\nCount total number of duplicate elements in an array:\n");
//        Console.Write("---------------------------------------------------------\n");

//        Console.Write("Input the number of elements to be stored in the array :");
//        n = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Input {0} elements in the array :\n", n);
//        for (i = 0; i < n; i++)
//        {
//            Console.Write("element - {0} : ", i);
//            arr1[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        /*Finds duplicate elements in the array */
//        for (i = 0; i < n; i++)
//        {
//            for (j = i + 1; j < n; j++)
//            {
//                /*Increment the counter when the seaarch value is duplicate.*/
//                if (arr1[i] == arr1[j])
//                {
//                    ctr++;
//                    break;
//                }
//            }
//        }

//        Console.Write("\nTotal number of duplicate elements found in the array is : {0}\n\n", ctr);
//    }
//}
