using System;

namespace A070_StaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 30, c = 20;
            Console.WriteLine("the maximum number is {0}", Larger(Larger(a, b), c));
        }

        private static int Larger(int a , int b)
        {
            return (a >= b) ? a : b;
        }
    }
}
