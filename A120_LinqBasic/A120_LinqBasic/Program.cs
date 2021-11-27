using System;
using System.Collections.Generic;
using System.Linq;
namespace A120_LinqBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int> { 123, 45, 12, 90, 235, 4, 7, 23, 22 };
            List<int> listSortedEven = new List<int>();

            foreach(var item in data)
            {
                if (item % 2 == 0)
                    listSortedEven.Add(item);
            }
            listSortedEven.Sort();

            Console.WriteLine("Using foreach: ");
            foreach (var item in listSortedEven)
                Console.Write(item + " ");
            Console.WriteLine();

            var sortedEven = from item in data
                             where item % 2 == 0
                             orderby item
                             select item;

            Console.WriteLine("\nUsing Linq: ");
            foreach (var item in sortedEven)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}
