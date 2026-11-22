// Importação de Biblioteca/Pacotes
using System;
using System.Collections.Generic;
using System.Text;

// Criação do Pacote
namespace ExemplosCSharp
{
    // Criação da Classe
    internal class Soma
    {
        // Criação do Método Main
        public static void Main(string[]args)
        {
            Console.WriteLine("Programa Soma");
            Console.WriteLine("Digite um número inteiro que desejo somar:");
            int numeroUm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int numeroDois = Convert.ToInt32(Console.ReadLine());

            int resultadoSoma = numeroUm + numeroDois;
            Console.WriteLine("A soma dos números é: " + resultadoSoma);

            // Convert.ToInt32() = Converte um valor para inteiro. / (16, 32, 94) é o tamanho aceito de caracteres numéricos
            // Console.ReadLine() = Ler uma linha de dados do teclado
            // Escreva e Escreval
            // Console.Write e Console.WriteLine
        }
    }
}


// Classe = Conjunto de Objetos 
// Objeto = Conjunto de Características