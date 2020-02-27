using System;

namespace Fase3
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


            string[] allCities = { city1, city2, city3, city4, city5, city6 };
            string[] ArrayCiudadesModificadas = new string[allCities.Length]; 
            
            Array.Sort(allCities);
            
            for(int i=0; i<allCities.Length; i++)
            {
                ArrayCiudadesModificadas[i] = allCities[i].Replace("a", "4");
            }

            Console.WriteLine("The array has been ordered and all 'a'-s have been replaced by '4'-s");
            
            foreach (string city in ArrayCiudadesModificadas) Console.WriteLine(city);


        }
    }
}
