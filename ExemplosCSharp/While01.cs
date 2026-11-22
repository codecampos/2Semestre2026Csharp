using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class While01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa de 0-10 no While");
            Console.WriteLine("");

            int i = 0;

            while (i < 11)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
