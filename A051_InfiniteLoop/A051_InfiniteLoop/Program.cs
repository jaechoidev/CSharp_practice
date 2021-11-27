using System;

namespace A051_InfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int saving = 1000;
            int days = 0;
            while(total < 1000000)
            {
                total += saving;
                saving *= 2;
                days += 1;
            }
            Console.WriteLine($"Total Savings : {total} , Period : {days}");
        }
    }
}
