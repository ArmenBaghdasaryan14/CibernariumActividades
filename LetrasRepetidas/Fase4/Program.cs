using System;
using System.Collections.Generic;

namespace Fase4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("##### Fase 4 #####");

            List<char> listMyName = new List<char>() { 'A', 'r', 'm', 'e', 'n' };
            List<char> listMySirname = new List<char>() { 'B', 'a', 'g', 'h', 'd', 'a', 's', 'a', 'r', 'y', 'a', 'n' };

            List<char> listFullName = new List<char>();
            listFullName.AddRange(listMyName);
            listFullName.Add(' ');
            listFullName.AddRange(listMySirname);

            foreach (char letter in listFullName)
            {
                Console.WriteLine(letter);
            }
     

        }

    }
}
