using System;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol;
            char symbolChar;
            //char[] vector = new char[5] { 'a', 'e', 'i', 'o', 'u' };  //Podríamos comprobar con este vector las vocales

            //El programa sólo aceptará letras en minúscula, e imprimirá por panrtalla si se trata de una consonante,
            //una vocal, o un número entero.


            do
            {

                Console.WriteLine("\nInput a symbol (lowercase): ");
                symbol = Console.ReadLine();
                Char.TryParse(symbol, out symbolChar); //Almacenamos en un "caracter" el símbolo, para poder almacenar tanto números como letras

                if (char.IsDigit(symbolChar))
                { 
                    Console.WriteLine("\nThe input symbol is a DIGIT"); //Primero comprobamos si el symbolo es un dígito
                } else if (char.IsSymbol(symbolChar))
                {
                    Console.WriteLine("\nThe input symbol is OTHER SYMBOL"); //A continuación comprobamos si el symbolo es un symbol
                } else if (char.IsLower(symbolChar) == false) //Comprobamos si el caracter introducido está en minúscula. De no serlo, saldrá por completo y lo pedirá de nuevo
                {
                    Console.WriteLine("\n****** The input symbol is not lowercase. ******");
                } else //Una vez comprobado que la letra introducida es minúscula, diferenciamos si se trata de una vocal o una consonante
                {
                    if ((symbolChar == 'a' || symbolChar == 'e' || symbolChar == 'i' || symbolChar == 'o' || symbolChar == 'u')) //Comprobamos si es una vocal
                    {
                        Console.WriteLine("\nThe input symbol is a VOWEL");
                    } else
                    {
                        Console.WriteLine("\nThe input symbol is a OTHER SYMBOL");
                    }
                } 

            } while ((char.IsLower(symbolChar) == false) && (char.IsDigit(symbolChar) == false) && (char.IsSymbol(symbolChar) == false));

            //El bucle solo se reptirá si el caracter es minúscula y además no es un dígito, y además es un symbolo.
            //ya que solo entrará entrará en el "if" de las letras si NO es un dígito y además NO es un symbolo

            Console.ReadLine();
            

        }
    }
}
