using System;

namespace A082_HanoiTower
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                double m = Mersenne(i);
                Console.WriteLine("mersenne({0}) = {1:N0} = {2:N1} days = {3:N1}years", i, m, m / 3600 / 24, m / 24 / 365);
            }

            Console.WriteLine("\nHanoi Tower: {0}, {1}-> {2}-> {3}", 4, 'A', 'B', 'C');
            Hanoi(4, 'A', 'C', 'B');
            
        }
        private static double Mersenne(int n)
        {
            return Math.Pow(2, n) - 1;
        }

        private static void Hanoi(int n, char from, char to, char by)
        {
            if (n == 1)
                Console.WriteLine("Move : {0} -> {1}", from, to);
            else
            {
                Hanoi(n - 1, from, by, to);
                Console.WriteLine("Move : {0} -> {1}", from, to);
                Hanoi(n - 1, by, to, from);
            }
        }
    }
}
