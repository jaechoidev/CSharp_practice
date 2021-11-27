using System;

namespace A063_BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] v = new int[30];

            for (int i = 0; i < 30; i++)
                v[i] = r.Next(1000);

            PrintArray("Before Sorting : ", v);

            Array.Sort(v);
            PrintArray("After Sorting: ", v);

            Console.Write("=> Enter a number to search: ");
            int key = int.Parse(Console.ReadLine());
            int count = 0;
            bool found = false;

            //linear search
            for (int i = 0; i < v.Length; i++)
            {
                count++;
                if (v[i] == key)
                {
                    Console.WriteLine("v[{0}] = {1}", i,key);
                    Console.WriteLine("The number of Comparison for Linear Search is {0}.", count);
                    found = true;
                    break;
                }
            }

            if (!found)
                Console.WriteLine("The number of Comparison for Linear Search is {0}.", count);
            Console.WriteLine("{0} is not found.", key);

            // Binary Search
            count = 0;
            int low = 0;
            int high = v.Length - 1;
            found = false;

            while ( low <= high)
            {
                count++;
                int mid = (low + high) / 2;
                if (key == v[mid])
                {
                    Console.WriteLine("v[{0}] = {1}", mid, key);
                    Console.WriteLine("The number of Comparison for Binary Search is {0}", count);
                    found = true;
                    break;
                }
                else if (key > v[mid])
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            if (!found)
                Console.WriteLine("The number of Comparison for Binary Search is {0}", count);
            Console.WriteLine("{0} is not found.", key);

        }
        private static void PrintArray(string s, int[] v)
        {
            Console.WriteLine(s);
            for (int i = 0; i < v.Length; i++)
            { 
                Console.Write("{0,6}{1}", v[i],
                    i%10 == 9? "\n" : "");
            }
        }
    }
}
