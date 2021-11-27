using System;

namespace A066_FieldsAndConstants
{
    class Product
    {
        public string name;
        public int price;
    }

    class MyMath
    {
        public static double PI = 3.14;
    }

    class MyCalendar
    {
        public const int months = 12;
        public const int weeks = 52;
        public const int days = 365;

        public const double daysPerWeek = (double)days / (double)weeks;
        public const double daysPerMonth = (double)days / (double)months;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.name = "watch";
            p.price = 1000;

            Console.WriteLine("{0} : {1:C}", p.name, p.price);
            Console.WriteLine("Circle: {0}", MyMath.PI);
            Console.WriteLine("A Month is {0:F3} days average.", MyCalendar.daysPerMonth);
        }
    }
}
