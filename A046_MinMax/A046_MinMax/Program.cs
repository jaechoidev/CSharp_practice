using System;

namespace A046_MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            double max = double.MinValue;
            double min = double.MaxValue;
            double sum = 0;
            int count = 0;
            while (true)
            {
                Console.Write("Enter Height (unit: cm, enter empty string to finish) : ");
                string inputHeight = Console.ReadLine();
                if (inputHeight == "")
                    break;

                double h = double.Parse(inputHeight);
                if (h > max)
                    max = h;
                if (h < min)
                    min = h;
                sum += h;
                count += 1;
                printResult(max, min, sum, count);
            }
            Console.WriteLine("==================FINAL RESULT=================");
            printResult(max, min, sum, count);
        }

        static void printResult(double max, double min, double sum, int count)
        {
            Console.WriteLine("Max : {0} , Min : {1} , #of People : {2} , Sum : {3} , Avg : {4}",
                max == double.MinValue ? 0 : max,
                min == double.MaxValue ? 0 : min,
                count,
                sum,
                count == 0 ? 0 : sum / count
                );
        }
    }
}
