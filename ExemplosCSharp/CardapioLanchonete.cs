using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class CardapioLanchonete
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Programa Restaurante");
            Console.WriteLine("");

            Console.WriteLine("===================================");
            Console.WriteLine("|          CARDÁPIO               |");            
            Console.WriteLine("===================================");
            Console.WriteLine("| Código |    Produto    | Preço  |");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("|  1    | Hambúrguer    | R$ 15,00|");
            Console.WriteLine("|  2    | Pizza         | R$ 20,00|");
            Console.WriteLine("|  3    | Refrigerante  | R$  6,00|");
            Console.WriteLine("|  4    | Suco          | R$  8,00|");
            Console.WriteLine("===================================");
            Console.WriteLine("");

            Console.WriteLine("Digite um número:");
            int numero = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");

            switch (numero) {

                case 1:
                    Console.WriteLine("========================");
                    Console.WriteLine("| Hambúrguer | R$15,00 |");
                    Console.WriteLine("========================");
                    break;

                case 2:
                    Console.WriteLine("========================");
                    Console.WriteLine("|   Pizza   | R$20,00  |");
                    Console.WriteLine("========================");
                    break;

                case 3:
                    Console.WriteLine("=========================");
                    Console.WriteLine("| Refrigerante | R$6,00 |");
                    Console.WriteLine("=========================");
                    break;

                case 4:
                    Console.WriteLine("========================");
                    Console.WriteLine("|   Suco    |  R$8,00  |");
                    Console.WriteLine("========================");
                    break;

                default:
                    Console.WriteLine("Código digita errado/não existe!");
                    break;
            
            }
        }
    }
}
