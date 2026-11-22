using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class While03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa de 2-30 em números pares While");
            Console.WriteLine("");

            int numero = 2;

            while (numero < 31)
            {
                Console.WriteLine(numero);
                numero += 2;
            }
        }
    }
}
