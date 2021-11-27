using System;
using System.Collections.Generic;
using System.Linq;

namespace A121_LinqBasic2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int> { 123, 45, 12, 89, 442, 1, 3, 54, 67 };

            Print("data : ", data);

            var listEven = from item in data
                           where (item > 20 && item % 2 == 0)
                           orderby item descending
                           select item;

            Print("Searching result for Even number bigger than 20 : ", listEven);

            var listsorted = from item in listEven
                             orderby item ascending
                             select item * 2;

            Print("multiply by 2 and sort ascending order : ", listsorted);

        }

        private static void Print(string s, IEnumerable<int> data)
        {
            Console.WriteLine(s);
            foreach (var i in data)
                Console.Write(" " + i);
            Console.WriteLine();
        }
    }
}
