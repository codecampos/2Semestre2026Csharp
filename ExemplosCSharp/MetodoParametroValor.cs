using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class MetodoParametroValor
    {
        static void paisesMetodo(string pais = "Brasil")
        {
            Console.WriteLine(pais);
        }

        public static void Main(string[] args)
        {
            paisesMetodo("Países que jogaram a copa do mundo:");
            paisesMetodo("Alemanha");
            paisesMetodo("Belgica");
            paisesMetodo("Japão");
            paisesMetodo();
        }
    }
}
