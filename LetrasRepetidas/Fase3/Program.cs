using System;
using System.Collections.Generic;

namespace Fase3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("##### Fase 3 #####");

            List<char> listMyName = new List<char>() { 'A', 'r', 'm', 'e', 'n' };
            Dictionary<char, int> myNameInfo = new Dictionary<char, int>();

            foreach (char letter in listMyName)
            {
                if (myNameInfo.ContainsKey(letter))
                {
                    myNameInfo[letter]++;
                }
                else
                {
                    myNameInfo.Add(letter, 1);
                }
            }

            foreach (KeyValuePair<char, int> item in myNameInfo)
            {
                Console.WriteLine(item.Key.ToString() + " : " + item.Value);
            }

        }

    }
}
