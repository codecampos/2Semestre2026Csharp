using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class EstruturaDeDecisaoEncadeada
    {
        public static void Main(String[] args)
        {
        
            Console.WriteLine("Programa Decisão Encadeada");
            Console.WriteLine("");
             
            Console.WriteLine("Digite sua idade:");
            int idade = Convert.ToInt16(Console.ReadLine());
           
            if (idade < 16)
            {
                Console.WriteLine("Você não pode votar!");
            }
            else if (idade < 18)
            {
                Console.WriteLine("Voto opcional");
            }
            else
            {
                Console.WriteLine("Voto obrigatório");
            }

        }
    }
}
