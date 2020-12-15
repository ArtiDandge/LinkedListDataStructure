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
        /// Method to insert node at perticulat position
        /// </summary>
        /// <param name="position">position where node to be inserted</param>
        /// <param name="data">data of that node</param>
        internal void InsertionAtPerticulatPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }

            if (position == 1)
            {
                var newNode = new Node(data);
                newNode = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Out of Rang");
            }
            Console.WriteLine("\n head is printing" + head.data + "\n");
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

        internal Node RemoveFirstNode()
        {
            if(this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }

    }
}
