using System;

namespace A029_StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string max = String.Format("0x{0:X} {0:E} {0:N}", Int64.MaxValue);
            Console.WriteLine(max);

            Decimal exchangeRate = 1129.20m;

            string s = String.Format("The Korean Currency is now {0}.", exchangeRate);
            Console.WriteLine(s);

            s = String.Format("The Korean Currency is now {0:C2}.", exchangeRate);
            Console.WriteLine(s);

            s = String.Format("Today is {0:d}, and the time is {0:t}.", DateTime.Now);
            Console.WriteLine(s);

            TimeSpan duration = new TimeSpan(1, 12, 23, 62);
            string output = String.Format("Duration: {0:c}", duration);
            Console.WriteLine(output);
        }
    }
}
