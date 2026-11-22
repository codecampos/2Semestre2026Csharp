using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ExemplosCSharp
{
    internal class ExemploFor
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa contagem de 0 a 11.");
            Console.WriteLine("");
            Console.WriteLine("Contagem");

            for (int contador = 0; contador < 12; contador++)
            {
                Console.WriteLine(contador);
            }
            
        }
    }
}
