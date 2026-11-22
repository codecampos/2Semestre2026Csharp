using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class ExemploDoWhile
    {
        public static void Main(string[] args)
        {
            int contadora = 0;

            Console.WriteLine("Programa contador de 0 a 11");
            Console.WriteLine("");
            do
            {
                Console.WriteLine(contadora);
                contadora++;
            }
            while (contadora < 11);
        }
    }
}
