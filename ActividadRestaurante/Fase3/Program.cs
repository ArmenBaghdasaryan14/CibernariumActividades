﻿using System;
using System.Collections.Generic;

namespace Fase3
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
            List<string> listOfOrders = new List<string> { };


            for (int i = 0; i < menuPrecios.Length; i++)
            {
                Console.WriteLine("Nombre del plato " + (i + 1) + ":");
                menuPlatos[i] = Console.ReadLine();

                Console.WriteLine("Precio del plato " + (i + 1) + ":");
                menuPrecios[i] = Int32.Parse(Console.ReadLine());
            }


            while (wantsMoreDishes)
            {
                        
                Console.WriteLine("Por favor, selecione una opción entre 1 y " + menuPlatos.Length);

                for (int i = 0; i < menuPlatos.Length; i++)
                {
                    Console.WriteLine(menuPlatos[i] + " : " + menuPrecios[i]);
                }

                userInput = Console.ReadLine();
                listOfOrders.Add(userInput);

         
                Console.WriteLine("Quiere pedir alguna cosa más? [S para si / N para no]");
                userInput = Console.ReadLine();

                if (userInput == "S" || userInput == "s")
                {
                    wantsMoreDishes = true;
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

            Console.WriteLine("Order completed");


            foreach(string order in listOfOrders)
            {
                if("12345".IndexOf(order) >= 0)
                {
                    int i = Int32.Parse(order);
                    totalPrice += menuPrecios[i];
                }
                else
                {
                    Console.WriteLine("The chosen option is not in the menu... ");
                    totalPrice = 0;  // reset
                    break;
                }
            }

            Console.WriteLine("El precio total es de " + totalPrice + " EUROS. \n");


        }
    }
}
