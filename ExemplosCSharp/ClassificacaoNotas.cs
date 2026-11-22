using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class ClassificacaoNotas
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa Aprovado ou Reprovado");
            Console.WriteLine("");

            Console.WriteLine("Digite sua nota");
            int nota = Convert.ToInt16(Console.ReadLine());

            if (nota < 5)
            {
                Console.WriteLine("Reprovado!");
            }
            else if (nota < 7)
            {
                Console.WriteLine("Recuperação!");
            }
            else
            {
                Console.WriteLine("Aprovado!");
            }
        }
    }
}
