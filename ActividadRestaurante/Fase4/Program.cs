using System;
using System.Collections.Generic;

namespace Fase4
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
            int residuo;

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


            foreach (string order in listOfOrders)
            {
                if ("12345".IndexOf(order) >= 0)
                {
                    int i = Int32.Parse(order);
                    totalPrice += menuPrecios[i-1];
                }
                else
                {
                    Console.WriteLine("The chosen option is not in the menu... ");
                    totalPrice = 0;  // reset
                    break;
                }
            }

            residuo = totalPrice;
    
            while(residuo > 0)
            {
                if (residuo >= 500)
                {
                    euro_500 += residuo / 500;
                    residuo = residuo % 500;
                }
                else if(residuo >= 200)
                {
                    euro_200 += residuo / 200;
                    residuo = residuo % 200;
                }
                else if(residuo >= 100)
                {
                    euro_100 += residuo / 100;
                    residuo = residuo % 100;
                }
                else if(residuo >= 50)
                {
                    euro_50 += residuo / 50;
                    residuo = residuo % 50;
                }
                else if (residuo >= 20)
                {
                    euro_20 += residuo / 20;
                    residuo = residuo % 20;
                }
                else if (residuo >= 10)
                {
                    euro_10 += residuo / 10;
                    residuo = residuo % 10;
                }
                else if (residuo >= 5)
                {
                    euro_5 += residuo / 5;
                    residuo = residuo % 5;
                }
                else if (residuo >= 2)
                {
                    euro_2 += residuo / 2;
                    residuo = residuo % 2;
                }
                else if (residuo >= 1)
                {
                    euro_1 += residuo / 1;
                    residuo = residuo % 1;
                }
                

            }

            Console.WriteLine("El precio total es de " + totalPrice + " EUROS. \n");

            Console.WriteLine("Billete de 500: " + euro_500 + "unidades");
            Console.WriteLine("Billete de 200: " + euro_200 + "unidades");
            Console.WriteLine("Billete de 100: " + euro_100 + "unidades");
            Console.WriteLine("Billete de 50: "  + euro_50  + "unidades");
            Console.WriteLine("Billete de 20: "  + euro_20  + "unidades");
            Console.WriteLine("Billete de 10: "  + euro_10  + "unidades");
            Console.WriteLine("Billete de 5: "   + euro_5   + "unidades");

            Console.WriteLine("Monedas de 2: " + euro_2 + "unidades");
            Console.WriteLine("Monedas de 1: " + euro_1 + "unidad");

        }
    }
}
