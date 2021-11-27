using System;

namespace A033_ConstAndReadonly
{
    class ConstEx
    {
        public const int number = 3;
    }

    class ReadonlyEx
    {
        public readonly int number = 10;
        public ReadonlyEx()
        {
            number = 20;
        }
        public ReadonlyEx(int n)
        {
            number = n;
        }
    }

    class Program
    {
        public const int testing_const = 5;
        public readonly int testing_readonly = 500;

        static void Main(string[] args)
        {
            Console.WriteLine(ConstEx.number);

            ReadonlyEx inst1 = new ReadonlyEx();
            Console.WriteLine(inst1.number);

            ReadonlyEx inst2 = new ReadonlyEx(100);
            Console.WriteLine(inst2.number);

            Console.WriteLine(testing_const);

            // something is weird.. 
            Program test = new Program();
            Console.WriteLine(test.testing_readonly);

        }
    }
}
