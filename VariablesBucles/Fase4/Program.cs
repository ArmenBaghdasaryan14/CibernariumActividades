using System;

namespace Fase4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Armen";
            string sirname1 = "Baghdasaryan";
            string sirname2 = "Yeritsyan";
            string leapBirthYearText = "Mi año de nacimiento es bisiesto";
            string notLeapBirthYearText = "Mi año de nacimiento no es bisiesto";

            int birthDay = 25;
            int birthMonth = 2;
            int birthYear = 1992;
            const int initialYear = 1948;
            bool birthYearIsLeap = false;

            string fullName = name + " " + sirname1 + " " + sirname2;
            string birthDate = birthDay + "/" + birthMonth + "/" + birthYear;
            
            if ((birthYear - initialYear) % 4 == 0) 
                birthYearIsLeap = true;


            Console.WriteLine("Mi nombre es " + fullName);
            Console.WriteLine("Nací el " + birthDate);

            if (birthYearIsLeap == true)  
                Console.WriteLine(leapBirthYearText);
            else 
                Console.WriteLine(notLeapBirthYearText);

            
        }
    }
}
