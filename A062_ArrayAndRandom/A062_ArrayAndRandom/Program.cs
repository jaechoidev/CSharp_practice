using System;

namespace A062_ArrayAndRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] v = new int[20];

            for (int i = 0; i < v.Length; i++)
                v[i] = r.Next(100);
            PrintArray(v);

            int max = v[0];
            int min = v[0];
            double sum = 0;

            // linear searching..
            for (int i = 1; i<v.Length; i++)
            {
                if (v[i] > max)
                    max = v[i];
                if (v[i] < min)
                    min = v[i];
                sum += v[i];
            }
            Console.WriteLine("max : {0}", max);
            Console.WriteLine("min : {0}", min);
            Console.WriteLine("sum : {0}", sum);
            Console.WriteLine("avg : {0}", sum / v.Length);

        }

        private static void PrintArray(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
                Console.Write("{0,5}{1}", v[i], (i % 10 == 9) ? "\n" : "");
        }
    }
}
