using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    class Program
    {

        public static int suma (int v)
        {
            return v+1;
        }

        public static int sumaRef(ref int v)
        {
            v = v + 1;
            return v;
        }

        static void Main(string[] args)
        {
            int a = 8;
            int b = sumaRef(ref a);
            
            Console.WriteLine(""+a);
            Console.WriteLine(b.ToString());

            Console.ReadLine();


        }
    }
}
