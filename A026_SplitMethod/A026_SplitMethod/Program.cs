using System;

namespace A026_SplitMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter numbers that want to sum: ");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            int sum = 0;
            string[] v = s.Split();
            foreach (var i in v)
            {
                if (i != "" && i != " ") // this condition is needed if there's no Trim and other spliting details
                    sum += int.Parse(i);
            }
            Console.WriteLine("The result is {0}", sum);
        }
    }
}
