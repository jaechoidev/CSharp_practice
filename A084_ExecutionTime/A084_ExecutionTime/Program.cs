using System;

namespace A084_ExecutionTime
{
    class Program
    {
        static int[] f = new int[50];

        static void Main(string[] args)
        {
            Console.WriteLine("print n Fibos.");
            Console.Write("Enter n : ");
            int n = int.Parse(Console.ReadLine());

            var watch = System.Diagnostics.Stopwatch.StartNew();

            f[1] = f[2] = 1;
            for (int i = 3; i <= n; i++)
                f[i] = f[i - 1] + f[i - 2];

            for (int i = 1; i <= n; i++)
                Console.Write("{0} ", f[i]);
            Console.WriteLine();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("time is {0}ms \n", elapsedMs);

            watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 1; i <= n; i++)
                Console.Write("{0} ", FiboRecursive(i));
            Console.WriteLine();

            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("time is {0}ms \n", elapsedMs);

        }

        private static int FiboRecursive(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            else
                return FiboRecursive(n - 1) + FiboRecursive(n - 2);
        }
    }
}
