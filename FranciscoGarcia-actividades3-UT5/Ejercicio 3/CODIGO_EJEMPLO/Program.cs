using System;
using System.Text.RegularExpressions;

namespace ej1
{
    /// <summary>
    /// Clase principal del programa.
    /// </summary>
    class Program
    {        
        static void Main()
        {
            Console.WriteLine(new Ficha("6, 5"));
            Console.WriteLine(new Ficha("CUATRO , cinco"));
            Console.WriteLine(new Ficha("3 ,Dos"));
            Console.WriteLine(new Ficha("6 , 8"));
            Console.WriteLine(new Ficha("2 , hola"));         

        }       
    }
}

