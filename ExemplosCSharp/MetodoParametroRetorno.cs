using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class MetodoParametroRetorno
    {
        static int meuMetodo(int x)
        {
            return 5 + x;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(meuMetodo(3));
        }
    }
}
