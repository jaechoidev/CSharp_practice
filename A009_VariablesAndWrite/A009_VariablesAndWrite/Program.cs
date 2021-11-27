using System;

namespace A009_VariablesAndWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1 = 100;
            double v2 = 1.234;

            //Console.WriteLine(v1,v2); // getting error
            Console.WriteLine(v1.ToString() + ", " + v2.ToString()); // convert variables to string
            Console.WriteLine("v1 = " + v1 + ", v2 = " + v2); // use + to make variables one string
            Console.WriteLine("v1 = {0}, v2 = {1}", v1, v2); // use string format 
            Console.WriteLine($"v1 = {v1}, v2 = {v2}"); // string interpolation
        }
    }
}
