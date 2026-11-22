using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class ExemploForeach02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa Idade");
            Console.WriteLine("");

            int[] idade = { 18, 15, 145, 67, 50, 30 };
            foreach (int contadora in idade);
            {
                Console.WriteLine(idade);
            }
        }
    }
}
