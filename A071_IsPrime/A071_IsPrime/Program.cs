using System;

namespace A071_IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 2; i <= 100; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write("{0} ", i);
                    count++;
                }
            }
            Console.WriteLine("\n There are {0} prime numbers between 2 and 100.", count);
        }

        private static bool IsPrime(int x)
        {
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }
    }
}
