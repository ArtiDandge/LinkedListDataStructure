using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDataStructure
{
    public class LinkedList
    {
        internal Node head;
        /// <summary>
        /// Method to add nodes to the linked list
        /// </summary>
        /// <param name="data">data represents linked list node data</param>
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                node.next = head;
                this.head = node;
            }
            Console.WriteLine("{0} inserted to th linked list", node.data);

        }

        /// <summary>
        /// Method to display linked list 
        /// </summary>
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("This Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data+" ");
                temp = temp.next;
            }
        }

    }
}
