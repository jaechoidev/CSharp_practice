using System;

namespace A079_RecursivePower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Power(x,y).");
            Console.Write("Enter x : ");
            double x = double.Parse(Console.ReadLine());
            Console.Write(" Enter y: ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine(" {0}^{1} = {2}", x, y, Power(x, y));
        }

        private static double Power (double x, double y)
        {
            if (y == 0) // base case
                return 1;
            else
                return x * Power(x, y - 1); // recursive call
        }
    }
}

