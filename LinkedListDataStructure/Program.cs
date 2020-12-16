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
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            list.InsertionAtPerticularPosition(40);
            Console.WriteLine("---------List after insertion of 40 --------");
            list.Display();
        }
    }
}
