using System;

namespace A023_ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            string result = (input > 0) ? "positive" : "negative";
            Console.WriteLine("{0} is {1}", input, result);
            Console.WriteLine("{0} is {1}", input, (input % 2 == 0) ? "even" : "odd");

            for (int i = 1; i <= 500; i++)
            {
                Console.Write("{0,4}{1}", i, i % 10 != 0 ? "" : "\n"); // this is something new?
            }
        }
    }
}
