using System;

namespace A047_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x power of y :");
            Console.Write("Enter x : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y : ");
            int y = int.Parse(Console.ReadLine());

            int pow = 1;

            for (int i = 0; i < y; ++i)
                pow *= x;

            Console.WriteLine($"{x} power of {y} is {pow}.");

        }
    }
}
