using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class ExemploWhile
    {
        public static void Main(string[] args)
        {
            int contadora = 0;

            while (contadora < 11)
            {
                Console.WriteLine(contadora);
                contadora++;
            }
        }
    }
}
