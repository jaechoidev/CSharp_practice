using System;

namespace A008_ConsoleWriteMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("prime number under 10 : {0}, {1}, {2}, {3}", 2, 3, 5, 7);

            string primes;
            primes = String.Format("prime number under 10: {0}, {1}, {2}, {3}", 2, 3, 5, 7);
            Console.WriteLine(primes);
        }
    }
}
