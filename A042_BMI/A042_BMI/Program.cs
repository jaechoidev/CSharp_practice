using System;

namespace A042_BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            sum = 0;
            int j = 0;
            while (j <= 100)
            {
                if (j % 2 == 1)
                    sum += j;
                j++;
            }
            Console.WriteLine(sum);

            double fracSum = 0;
            j = 1;
            while(j <= 100)
            {
                fracSum += (double)1 / j;
                ++j;
            }
            Console.WriteLine(fracSum);
        }
    }
}
