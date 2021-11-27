using System;

namespace A044_NumberSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0,5} {1,10} {2,7} {3,6}", "Decimal", "Binary", "Octal", "Hex");

            for (int i = 1; i <= 128; i++)
            {
                Console.WriteLine("{0,7} {1,10} {2,7} {3,6}",
                                     i,
                                     Convert.ToString(i, 2).PadLeft(8, '0'),
                                     Convert.ToString(i, 8),
                                     Convert.ToString(i, 16));
            }
        }
    }
}
