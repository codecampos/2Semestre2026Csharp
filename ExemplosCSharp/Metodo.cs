using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class Metodo
    {
        static void primeiroMetodo(string nome)
        {
            Console.WriteLine(nome + " Campos");
        }
        public static void Main(string[] args)
        {
            primeiroMetodo("Miguel");
            primeiroMetodo("Jonas");
            primeiroMetodo("Tati");

        }
    }
}
