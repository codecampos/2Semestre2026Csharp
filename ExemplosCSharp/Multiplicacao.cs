using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class Multiplicacao
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Programa Multiplicação");
            Console.WriteLine("Digite o primeiro número inteiro");
            int numeroUm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int numeroDois = Convert.ToInt32(Console.ReadLine());

            int resultadoMultiplicacao = numeroUm * numeroDois;
            Console.WriteLine("A multiplicação dos números é:" + resultadoMultiplicacao);

        }
    }
}
