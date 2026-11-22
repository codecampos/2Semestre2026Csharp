using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class MetodoParametro
    {
        static void metodoParametro(string nome, int idade)
        {
            Console.WriteLine(nome + " Campos " + idade);
        }
        public static void Main(string[] args)
        {
            metodoParametro("Miguel", 20);
            metodoParametro("Juliana", 31);
            metodoParametro("João", 61);
        }
    }
}
