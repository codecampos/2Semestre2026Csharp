using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class While05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa de 50-0 de 5 em 5 do While");
            Console.WriteLine("");

            int numero = 50;

            while (numero > -1)
            {
                Console.WriteLine(numero);
                numero -= 5;
            }
        }
    }
}
