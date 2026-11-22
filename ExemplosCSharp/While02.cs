using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class While02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa de 20-1 no While");
            Console.WriteLine("");

            int numero = 20;

            while (numero > -1)
            {
                Console.WriteLine(numero);
                numero--;
            }
        }
    }
}
