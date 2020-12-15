using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("LinkedListTest")]
namespace LinkedListDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Data Structure Problem");
            LinkedList list = new LinkedList();
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Display();
            list.Search(30);
        }
    }
}
