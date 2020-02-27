using System;
using System.Collections.Generic;

namespace Fase2
{
    class Program
    {
        static void Main(string[] args)
        {

            int euro_1 = 0;
            int euro_2 = 0;
            int euro_5 = 0;
            int euro_10 = 0;
            int euro_20 = 0;
            int euro_50 = 0;
            int euro_100 = 0;
            int euro_200 = 0;
            int euro_500 = 0;
            int totalPrice = 0;

            int[] menuPrecios = new int[5];
            string[] menuPlatos = new string[5];

            string userInput;
            bool wantsMoreDishes = true;
            bool correctDishIsSelected = false;
            List<string> listOfOrders = new List<string>{};


            for (int i=0; i<menuPrecios.Length; i++)
            {
                Console.WriteLine("Nombre del plato " + (i + 1) + ":");
                menuPlatos[i] = Console.ReadLine();

                Console.WriteLine("Precio del plato " + (i + 1) + ":");
                menuPrecios[i] = Int32.Parse(Console.ReadLine());
            }


            while (wantsMoreDishes) {
                while (!correctDishIsSelected) { 
                    Console.WriteLine("Por favor, selecione una opción entre 1 y " + menuPlatos.Length);

                    for(int i=0; i<menuPlatos.Length; i++)
                    {
                        Console.WriteLine(menuPlatos[i] + " : " + menuPrecios[i]);
                    }

                    userInput = Console.ReadLine();
                    if( "12345".IndexOf(userInput) >= 0)
                    {
                        listOfOrders.Add(userInput);
                        correctDishIsSelected = true;
                    }
                    else
                    {
                        Console.WriteLine("Opción incorrecta...");
                        correctDishIsSelected = false;
                }
                }


                if (correctDishIsSelected)
                {
                    Console.WriteLine("Quiere pedir alguna cosa más? [S para si / N para no]");
                    userInput = Console.ReadLine();

                    if (userInput == "S" || userInput == "s")
                    {
                        wantsMoreDishes = true;
                        correctDishIsSelected = false;
                    }
                    else if (userInput == "N" || userInput == "n")
                    {
                        wantsMoreDishes = false;
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida. Por favor, introduzca 'S' o 'N'");
                    }
                }
        
            }

            Console.WriteLine("Order completed");



        }
    }
}
