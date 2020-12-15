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
            Console.WriteLine("\nList Contains following data");
            list.Display();
            list.Add(30);
            Console.WriteLine("\nList Contains following data");
            list.Display();
            list.Add(56);
            Console.WriteLine("\nList Contains following data");           
            list.Display();

           
        }
    }
}
