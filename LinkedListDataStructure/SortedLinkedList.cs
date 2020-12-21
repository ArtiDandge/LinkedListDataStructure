using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDataStructure
{
    public class SortedLinkedList
    {
        internal Node head;

        /// <summary>
        /// Method to add node in sorted order
        /// </summary>
        /// <param name="new_node">node to be inserted</param>
        public void sortedInsert(Node new_node)
        {
            Node current;
            if (head == null || head.data >= new_node.data)
            {
                new_node.next = head;
                head = new_node;
            }
            else
            {
                current = head;

                while (current.next != null && current.next.data < new_node.data)
                    current = current.next;

                new_node.next = current.next;
                current.next = new_node;
            }
        }

        /// <summary>
        /// Method to create node
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        internal Node newNode(int data)
        {
            Node x = new Node(data);
            return x;
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
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
