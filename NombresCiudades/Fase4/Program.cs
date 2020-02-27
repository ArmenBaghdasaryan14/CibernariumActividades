using System;
using System.Collections.Generic;

namespace Fase4
{
    class Program
    {
        static void Main(string[] args)
        {

            string city1;
            string city2;
            string city3;
            string city4;
            string city5;
            string city6;

            Console.WriteLine("Please, introduce a city name: ");
            city1 = Console.ReadLine();

            Console.WriteLine("Please, introduce a city name: ");
            city2 = Console.ReadLine();

            Console.WriteLine("Please, introduce a city name: ");
            city3 = Console.ReadLine();

            Console.WriteLine("Please, introduce a city name: ");
            city4 = Console.ReadLine();

            Console.WriteLine("Please, introduce a city name: ");
            city5 = Console.ReadLine();

            Console.WriteLine("Please, introduce a city name: ");
            city6 = Console.ReadLine();

           
            string[] array_city1 = new string[city1.Length];
            string[] array_city2 = new string[city2.Length];
            string[] array_city3 = new string[city3.Length];
            string[] array_city4 = new string[city4.Length];
            string[] array_city5 = new string[city5.Length];
            string[] array_city6 = new string[city6.Length];


            for (int i = 0; i < array_city1.Length; i++) array_city1[i] = city1[i].ToString();
            for (int i = 0; i < array_city2.Length; i++) array_city2[i] = city2[i].ToString();
            for (int i = 0; i < array_city3.Length; i++) array_city3[i] = city3[i].ToString();
            for (int i = 0; i < array_city4.Length; i++) array_city4[i] = city4[i].ToString();
            for (int i = 0; i < array_city5.Length; i++) array_city5[i] = city5[i].ToString();
            for (int i = 0; i < array_city6.Length; i++) array_city6[i] = city6[i].ToString();


            Console.WriteLine("Inverted city names: ");

            for (int i = array_city1.Length - 1; i >= 0; i--) Console.Write(array_city1[i]);
            Console.WriteLine("");

            for (int i = array_city2.Length - 1; i >= 0; i--) Console.Write(array_city2[i]);
            Console.WriteLine("");

            for (int i = array_city3.Length - 1; i >= 0; i--) Console.Write(array_city3[i]);
            Console.WriteLine("");

            for (int i = array_city4.Length - 1; i >= 0; i--) Console.Write(array_city4[i]);
            Console.WriteLine("");

            for (int i = array_city5.Length - 1; i >= 0; i--) Console.Write(array_city5[i]);
            Console.WriteLine("");

            for (int i = array_city6.Length - 1; i >= 0; i--) Console.Write(array_city6[i]);
            Console.WriteLine("");


        }
    }
}
