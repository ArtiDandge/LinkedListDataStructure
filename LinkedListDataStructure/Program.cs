using System;

namespace LinkedListDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Data Structure Problem");
            LinkedList list = new LinkedList();
            list.Add(70);
            list.Add(56);
            Console.WriteLine("\nList Contains following data");
            list.Display();

            list.InsertionAtPerticulatPosition(2,30);
            Console.WriteLine("\nList Contains following data");
            list.Display();

            list.RemoveFirstNode();
            Console.WriteLine("\nList Contains following data");
            list.Display();


           
        }
    }
}
