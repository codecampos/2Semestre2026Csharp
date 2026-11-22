using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class EscolhaCaso
    {
        public static void Main(String[] args)
        {
            
            Console.WriteLine("Programa Escolha Caso");
            Console.WriteLine("");

            Console.WriteLine("Digite um dia correspondente ao dia da semana: ");
            int dia = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;

                case 2:
                    Console.WriteLine("Segunda-Feira");
                    break;

                case 3:
                    Console.WriteLine("Terça-Feira");
                    break;

                case 4:
                    Console.WriteLine("Quarta-Feira");
                    break;

                case 5:
                    Console.WriteLine("Quinta-Feira");
                    break;

                case 6:
                    Console.WriteLine("Quinta-Feira");
                    break;

                case 7:
                    Console.WriteLine("Sexta-Feira");
                    break;

                case 8:
                    Console.WriteLine("Sábado");
                    break;
            }
        }
    }
}
