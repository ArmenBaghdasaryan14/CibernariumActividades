using System;

namespace Fase1
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

            for(int i=0; i<menuPrecios.Length; i++)
            {
                Console.WriteLine("Nombre del plato " + (i + 1) + ":");
                menuPlatos[i] = Console.ReadLine();

                Console.WriteLine("Precio del plato " + (i + 1) + ":");
                menuPrecios[i] = Int32.Parse(Console.ReadLine());
            }
                      

        }
    }
}
