using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class Contagem15
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Programa para contar de 1 a 15");
            Console.WriteLine("");

            int i = 1;
            while (i < 16)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
