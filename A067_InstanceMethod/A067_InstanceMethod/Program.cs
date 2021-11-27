using System;

namespace A067_InstanceMethod
{
    class Date
    {
        public int year, month, day;

        public static bool IsLeapYear(int year)
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }

        static int[] days = { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334 };

        public int DaysofYear()
        {
            return days[month - 1] + day + (month > 2 && IsLeapYear(year) ? 1 : 0);
        }
    }

    class Program
    {
        static void Main()
        {
            Date xmas = new Date();

            xmas.year = 2018;
            xmas.month = 12;
            xmas.day = 25;

            Console.WriteLine("xmas : {0}/{1}/{2} is the {3} th day of the year.", xmas.year, xmas.month, xmas.day, xmas.DaysofYear());

            if (Date.IsLeapYear(2018) == true)
                Console.WriteLine("2018 is leap year.");
            else
                Console.WriteLine("2018 is normal year.");
        }
    }
}
