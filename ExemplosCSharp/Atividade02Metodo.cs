using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class Atividade02Metodo
    {
        static void RegistrarVenda(string nome, string produto, double valor)
        {
            Console.WriteLine(nome + " " + produto + " " + valor);
        }

        public static void Main(string[] args)
        {
            RegistrarVenda("Carlos", "Notebook", 3500.00);
        }
    }
}
