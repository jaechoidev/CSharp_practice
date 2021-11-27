using System;

namespace A039_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;
            i += 10;
            int j = (int)o;

            Console.WriteLine($"The value-type value i = {i}");
            Console.WriteLine($"The object-type value o = {o}");
            Console.WriteLine($"The value-type value j = {j}");

            object p = o;
            o = 100;
            Console.WriteLine($"The object-type value o = {o}");
            Console.WriteLine($"The object-type value p = {p}");

            /* 
             * i=123
             * o=address -> 123
             * j=123
             * i=133
             * 
             * p=address -> 123
             * o=address -> 100
             * 
             */
        }
    }
}
