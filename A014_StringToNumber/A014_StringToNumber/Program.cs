using System;

namespace A014_StringToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int value;

            Console.Write("1. Enter string to convert into integer : ");
            input = Console.ReadLine();
            bool result = Int32.TryParse(input, out value);

            if (!result)
                Console.WriteLine("'{0}' cannot conver to int. \n", input);
            else
                Console.WriteLine("int {0} is converted.\n", value);

            Console.WriteLine("2. Enter string to convert into double : ");
            input = Console.ReadLine();

            try
            {
                double m = Double.Parse(input);
                double m2 = Convert.ToDouble(input);
                Console.WriteLine("double '{0}' is converted.\n", m);
                Console.WriteLine("double '{0}' is converted.\n", m2);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
