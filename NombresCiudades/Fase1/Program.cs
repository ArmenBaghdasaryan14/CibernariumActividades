﻿using System;

namespace Fase1
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

            string allCities = string.Join(" , ", city1, city2, city3, city4, city5, city6);
            Console.WriteLine(allCities);

            
        }
    }
}
