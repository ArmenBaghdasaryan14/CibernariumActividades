using System;

namespace Fase2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int initialYear = 1948;
            const int leapPeriod = 4;
            const int myBirthYear = 1992;
            int tempYear = initialYear;
            int leapYearCount = 0;
            while(tempYear + leapPeriod < myBirthYear)
            {
                tempYear += leapPeriod;
                leapYearCount++;
            }

            Console.WriteLine(leapYearCount);

        }
    }
}
