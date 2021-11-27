using System;

namespace A015_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("Enter first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}", x, y, x + y);

            short value = short.MaxValue;
            Console.WriteLine("print binary, oct, decimal, hex.");
                
            int baseNum = 2;
            string s = Convert.ToString(value, baseNum);
            int i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2} = {2,16}", i, baseNum, s);

            baseNum = 8;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2} = {2,16}", i, baseNum, s);

            baseNum = 10;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2} = {2,16}", i, baseNum, s);

            baseNum = 16;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2} = {2,16}", i, baseNum, s);


        }
    }
}
