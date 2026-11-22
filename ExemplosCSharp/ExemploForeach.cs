using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class ExemploForeach
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa para mostrar carros");
            Console.WriteLine("");

            string[] cars = { "BMW", "Ferrari", "Ford", "Volvo"  };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
