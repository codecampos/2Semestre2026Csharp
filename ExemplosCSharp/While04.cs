using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class While04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa de 1-25 só número impar do While");
            Console.WriteLine("");

            int numero = 1;

            while (numero < 26)
            {
                Console.WriteLine(numero);
                numero += 2;
            }
        }
    }
}
