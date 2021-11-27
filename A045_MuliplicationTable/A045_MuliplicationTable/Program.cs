using System;

namespace A045_MuliplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========");
            for (int i = 1; i<=9; i++)
            {
                for (int j = 1; j<=9; j++)
                {
                    Console.Write("{0,2} x{1,2} = {2,2}    ", i, j, i*j);
                }
                Console.WriteLine("");

            }
        }
    }
}
