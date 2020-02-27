using System;
using System.Collections.Generic;

namespace Fase2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##### Fase 2 #####");

            List<char> listMyName = new List<char>() { 'A', 'r', 'm', '1', 'n' };
            string vocales = "AEIOUaeiou";
            string numbers = "0123456789";

            foreach (char letter in listMyName)
            {
                if (vocales.IndexOf(letter) >= 0)
                {
                    Console.WriteLine("VOCAL");
                }
                else if (numbers.IndexOf(letter) >= 0)
                {
                    Console.WriteLine("Los nombres de personas no contienen números");
                }
                else
                {
                    Console.WriteLine("CONSONANTE");
                }
            }

        }

    }
}
