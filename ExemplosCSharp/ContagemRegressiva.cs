using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class ContagemRegressiva
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Programa Contagem Regressiva");
            Console.WriteLine("");

            int i = 10;
            while (i > -1)
            {
                Console.WriteLine(i);
                i--;
            }
        }
    }
}
