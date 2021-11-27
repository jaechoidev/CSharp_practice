using System;

namespace A048_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            int factorial = int.Parse(Console.ReadLine());

            int sum = 1;

            for (int i = factorial; i > 0; i--)
                sum *= i;
            Console.WriteLine(sum);
        }
    }
}
