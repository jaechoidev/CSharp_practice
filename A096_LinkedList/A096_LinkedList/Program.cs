using System;

namespace A096_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Random r = new Random();

            for (int i = 0; i < 5; i++)
                list.InsertLast(r.Next(100));

            Console.WriteLine("5 Random values : ");
            list.Print();

            Console.Write("\nadd 10 to head, add 90 to rear. Press <Enter> ");
            Console.ReadLine();
            list.InsertFront(10);
            list.InsertLast(90);
            list.Print();

            Console.WriteLine("\n save y value after x node");
            Console.Write(" Enter x value ");
            int x = int.Parse(Console.ReadLine());
            Console.Write(" Enter y value: ");
            int y = int.Parse(Console.ReadLine());

            list.InsertAfter(x, y);
            list.Print();

            Console.Write("\n enter the value of the node to delete: ");
            int z = int.Parse(Console.ReadLine());
            list.DeleteNode(z);
            list.Print();

            Console.WriteLine("\n print reversed list. Press <Enter> ");
            Console.ReadLine();
            list.Reverse();
            list.Print();
        }
    }
}
