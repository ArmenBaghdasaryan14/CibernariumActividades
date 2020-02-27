using System;

namespace Fase3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int initialYear = 1948;
            const int leapPeriod = 4;
            const int myBirthYear = 1992;
            int leapYearCount = 0;
            bool birthYearIsLeap = false;
            string leapBirthYearText = "Mi año de nacimiento es bisiesto";
            string notLeapBirthYearText = "Mi año de nacimiento no es bisiesto";


            Console.WriteLine("Años bisiestos entre " + initialYear + " y " + myBirthYear);
            for (int i=initialYear; i<myBirthYear-leapPeriod; i += 4)
            {
                leapYearCount++;
                Console.WriteLine(initialYear + leapYearCount*4);
            }


            if((myBirthYear - initialYear) % 4 == 0)  birthYearIsLeap = true;
               

            if (birthYearIsLeap == true)
                Console.WriteLine(leapBirthYearText);
            else
                Console.WriteLine(notLeapBirthYearText);

        }
    }
}
