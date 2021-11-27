using System;

namespace A013_TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 25125236;
            long bignum = num; // implicit casting
            Console.WriteLine(bignum);

            double x = 1234.5;
            int a;

            a = (int)x; // explicit casting
            Console.WriteLine(a);
        }
    }
}
