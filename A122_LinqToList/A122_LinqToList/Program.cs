using System;
using System.Collections.Generic;
using System.Linq;

namespace A122_LinqToList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listData = new List<int> { 123, 456, 78, 5245, 11, 678, 352 };
            Print("Data: ", listData);

            List<int> listOdd = new List<int>();
            listOdd = SelectOddAndSort(listData);
            Print("Ordered Odd: ", listOdd);

            int[] arrEven;
            arrEven = SelectEvenAndSort(listData);
            Print("Ordered Even: ", arrEven);
        }

        private static List<int> SelectOddAndSort(List<int> listData)
        {
            return (from item in listData
                    where item % 2 == 1
                    orderby item
                    select item).ToList<int>();
        }
        private static int[] SelectEvenAndSort(List<int> listData)
        {
            return (from item in listData
                    where item % 2 == 0
                    orderby item
                    select item).ToArray<int>();
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
