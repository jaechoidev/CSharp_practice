using System;

namespace A040_LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                Console.WriteLine($"{year} is the leap year.");
            else
                Console.WriteLine($"{year} is the normal year.");

            if(DateTime.IsLeapYear(year))
                Console.WriteLine($"{year} is the leap year.");
            else
                Console.WriteLine($"{year} is the normal year.");
        }
    }
}
