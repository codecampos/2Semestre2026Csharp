using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class PeriodoDia
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa períodos");
            Console.WriteLine("");

            Console.WriteLine("Digite um número:");
            int numero = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");

            switch (numero) {
                
                case 1:
                    Console.WriteLine("Manhã");
                    break;

                case 2:
                    Console.WriteLine("Tarde");
                    break;

                case 3:
                    Console.WriteLine("Noite");
                    break;

                default:
                    Console.WriteLine("Período inválido!");
                    break;
            }
        }
    }
}
