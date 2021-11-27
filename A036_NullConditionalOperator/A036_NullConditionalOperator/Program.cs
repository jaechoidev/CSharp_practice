using System;

namespace A036_NullConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = null;

            Console.WriteLine("Print only animal names have greater than 4 chars.");

            do
            {
                LongNameAnimal(animal);
                Console.Write("Animal name: ");
            } while ((animal = Console.ReadLine()) != "");
        }

        private static void LongNameAnimal(string animal)
        {
            if (animal?.Length >= 4)
                Console.WriteLine($"{animal} : {animal.Length}");
        }
    }
}
