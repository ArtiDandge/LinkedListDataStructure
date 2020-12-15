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

            Console.WriteLine("----------Deletion of First Node---------");
            list.RemoveFirstNode();
            Console.WriteLine("\nList Contains following data after deleting first node");
            list.Display();
            list.Add(56);
            Console.WriteLine("\n----------Deletion of Last Node---------");
         
            list.RemoveLastNode();
            Console.WriteLine("\nList Contains following data after deleting last node");
            list.Display();

        }
    }
}
