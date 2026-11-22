using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class Subtracao
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Programa para subtração");
            Console.WriteLine("Digite primeiro número inteiro");
            int numeroUm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro: ");
            int numeroDois = Convert.ToInt32(Console.ReadLine());

            int resultadoSubtrair = numeroUm - numeroDois;
            Console.WriteLine("A subtração dos números é: " + resultadoSubtrair);
        }
    }
}
