using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            String numero;
            int numeroInt;
            int i = 0;
            int t = 0;
            int j = 0;


            Console.WriteLine("Inserte numero: ");
            numero = Console.ReadLine();

            bool correct = Int32.TryParse(numero, out numeroInt);

            //for (t = 0; t < 2; t++)
            //{
            //    for (i = 0; i < 4; i++)
            //    {

            //        Console.Write(numeroInt + " ");
            //    }
            //    Console.Write("\n");
            //    for (i = 0; i < 4; i++)
            //    {

            //        Console.Write(numeroInt);
            //    }
            //    Console.Write("\n");
            //}

            //Console.WriteLine();

            while (t < 2)
            {
                while (i < 4) {
                    Console.Write(numeroInt + " ");
                    i++;
                }
                Console.Write("\n");
                while (j < 4)
                {
                    Console.Write(numeroInt);
                    j++;
                }
                Console.Write("\n");
                i = 0;
                j = 0;
                t++;
            }

            Console.ReadLine();

        }
    }
}
