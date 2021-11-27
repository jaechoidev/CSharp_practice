using System;

namespace A050_FindingPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter precision number : ");
            int p = int.Parse(Console.ReadLine());
            double pi = 0.0;
            for (int i = 1; i <= p; i++)
            {
                if (i%2 == 1)
                    pi += 4.0 * (1.0 / (i * 2 - 1));
                else
                    pi -= 4.0 * (1.0 / (i * 2 - 1));
                Console.WriteLine("precision : {0}, PI : {1}", (i * 2 - 1), pi);
            }
            
        }
    }
}
