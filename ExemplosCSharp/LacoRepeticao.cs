using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class LacoRepeticao
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Laço de repetição");
            Console.WriteLine("");

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
