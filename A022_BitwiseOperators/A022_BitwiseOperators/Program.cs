using System;

namespace A022_BitwiseOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 14, y = 11, result;

            result = x | y;
            Console.WriteLine("{0} | {1} = {2}", x, y, result);
            result = x & y;
            Console.WriteLine("{0} & {1} = {2}", x, y, result);
            result = x ^ y;
            Console.WriteLine("{0} ^ {1} = {2}", x, y, result);
            result = ~x;
            Console.WriteLine("~{0} = {2}", x, y, result); // 1's compliment
            result = x << 2;
            Console.WriteLine("{0} << 2 = {2}", x, y, result); // muliply by 4
            result = y >> 1;
            Console.WriteLine("{0} >> 1 = {2}", x, y, result); // divided by 2

        }
    }
}
