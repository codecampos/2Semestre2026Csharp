using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class NumeroPositivo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa número positivo");

            Console.WriteLine("Digite um número");
            int numero = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");

            if (numero > 0)
            {
                Console.WriteLine("Número é positivo");
            }
        }
    }
}
