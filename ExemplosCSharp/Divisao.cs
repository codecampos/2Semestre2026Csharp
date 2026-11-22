using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class Divisao
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Programa Divisão");
            Console.WriteLine("Digite o primeiro número inteiro:");
            int numeroUm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro:");
            int numeroDois = Convert.ToInt32(Console.ReadLine());

            int resultadoDivisao = numeroUm / numeroDois;

            Console.WriteLine("A divisão ficou: " + resultadoDivisao);
        }
    }
}
