using System;

namespace A064_BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 3, 15, 2, 7, 1 ,10,9,11,4};
            PrintArray(v);

            for (int i = v.Length-1; i > 0; i--)
            {
                int updating = 0;
                for (int j = 0; j < i; j++)
                {
                    if (v[j] > v[j+1])
                    {
                        // using temp value
                        int t = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = t;
                        updating++;
                    }
                }
                if (updating == 0)
                    break;
                PrintArray(v);
            }
        }
        private static void PrintArray(int[] v)
        {
            foreach (var i in v)
                Console.Write("{0,5}", i);
            Console.WriteLine();
        }
    }
}
