using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
//using Static.Collections.Stack;


namespace Ejercicio8
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
            int[] vectorUnicos;
            //int valor_unico; //Usado para Peek y Pop
            int tamanoPila = 0;
            int repetido = 0;
            int i;
            int j;

            Stack miPila = new Stack();

            Console.WriteLine("Introduzca el tamaño del vector: ");
            tamaño = Console.ReadLine();
            Int32.TryParse(tamaño, out tamañoInt);

            vector = new int[tamañoInt];

            for (i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Introduzca el valor de la posición " + i + " del vector");
                valor = Console.ReadLine();
                Int32.TryParse(valor, out valorInt);
                vector[i] = valorInt;
            }

            for (i = 0; i < vector.Length; i++)
            {
                for (j = 0; j < vector.Length; j++)
                {
                    if (vector[i] == vector[j])
                    {
                        repetido = repetido + 1;
                    }
                }
                if (repetido <= 1) //repetido = 1 -> El mismo
                {
                    miPila.Push(vector[i]); //almaceno en Pila el valor que no está repetido
                    tamanoPila = tamanoPila + 1; //voy calculando el tamaño de pila donde se almacenan los valores no repetidos
                }
                repetido = 0;
            }

            //Pasamos la Pila a un Array
            vectorUnicos = new int[tamanoPila]; 
            object[] unicos = miPila.ToArray(); //Obtenemos un vector de objetos (No enteros)

            for (i = 0; i < unicos.Length; i++) //Tenemos que leer uno por uno los valores de ese vector de objetos
            {
                vectorUnicos[i] = (int)unicos[i]; //Pasamos cada uno de esos valores (enteros) a nuestro vector de enteros
            } 

            //Console.WriteLine("VECTOR PEEK"); //Devuelve solo la"cima" de la pila 

            //for (i = 0; i < tamanoPila; i++)
            //{
            //    valor_unico = (int)miPila.Peek();
            //    Console.WriteLine("Posición " + i + ": " + valor_unico);
            //}

            //Console.WriteLine("PILA POP"); //Devuelve el valor y lo retira de la Pila

            //for (i = 0; i < tamanoPila; i++)
            //{
            //    valor_unico = (int)miPila.Pop();
            //    Console.WriteLine("Posición " + i + ": " + valor_unico);
            //}

            for (i = 0; i < tamanoPila; i++)
            {
                Console.WriteLine("Posición " + i + ": " + vectorUnicos[i]);
            }

            Console.WriteLine("El número de elementos unicos es: " + tamanoPila);

            Console.ReadLine();

        }
    }
}