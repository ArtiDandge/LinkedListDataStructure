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
            list.Add(40);
            list.Add(30);
            list.Add(56);
            list.Display();
            list.deleteNode(40);
            Console.WriteLine("---------List after Deletion of 40 --------");
            list.Display();
            Console.WriteLine("Linked List Count: "+list.size());

            SortedLinkedList sortedList = new SortedLinkedList();
            Node newNode;
            newNode = sortedList.newNode(56);
            sortedList.sortedInsert(newNode);
            newNode = sortedList.newNode(30);
            sortedList.sortedInsert(newNode);
            newNode = sortedList.newNode(40);
            sortedList.sortedInsert(newNode);
            newNode = sortedList.newNode(70);
            sortedList.sortedInsert(newNode);

            Console.WriteLine("---------Sorted Linked List----------");
            sortedList.Display();


        }      
           
    }
}
