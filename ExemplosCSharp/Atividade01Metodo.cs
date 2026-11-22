using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class Atividade01Metodo
    {
        static void cadastrarFuncionario(string nome, int idade, string cargo)
        {
            Console.WriteLine(nome + " " + idade + " " +  cargo);
        }

        public static void Main(string[] args)
        {
            cadastrarFuncionario("Miguel", 20, "Desenvolvedor");
        }
    }
}
