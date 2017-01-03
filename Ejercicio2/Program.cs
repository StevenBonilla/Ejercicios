using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string first;
            int first1;
            string second;
            int second1;
            string swap;
            int suma;
            bool correct;
            bool correct2;

            do
            {
          
                Console.WriteLine("first= ");
                first = Console.ReadLine();


                Console.WriteLine("second= ");
                second = Console.ReadLine();

                swap = first;
                first = second;
                second = swap;

                correct = Int32.TryParse(first, out first1);
                correct2 = Int32.TryParse(second, out second1);

                if (correct && correct2)
                {
                    suma = first1 + second1;
                    Console.WriteLine("first After= " + first1);
                    Console.WriteLine("second After= " + second1);
                    Console.WriteLine("Suma= " + suma);
                }else
                {
                    Console.WriteLine("Try again");
                }

            } while (correct==false || correct2==false);

            Console.ReadLine();
        }
    }
}
