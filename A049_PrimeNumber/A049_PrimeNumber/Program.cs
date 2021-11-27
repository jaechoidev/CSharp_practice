using System;

namespace A049_PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int num = int.Parse(Console.ReadLine());
            int index;

            for (index = 2; index < num; index++)
            {
                if (num % index == 0)
                {
                    Console.WriteLine($"{num} is not prime number.");
                    break;
                }
            }
            if (index == num)
                Console.WriteLine($"{num} is prime number.");
        }
    }
}
