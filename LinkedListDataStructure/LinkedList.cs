using System;


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
<<<<<<< HEAD
                Node newNode = new Node(data);
                newNode.next = head;
                head = newNode;
=======
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                /*node.next = head;
                this.head = node;*/
>>>>>>> 56e307235671a734c5a6b60680626b01d36fec03
            }
            Console.WriteLine("{0} inserted to th linked list", node.data);
        }
        
        /// <summary>
        /// Method to insert node at middle possition of list
        /// </summary>
        /// <param name="data">data of that node</param>
        internal void InsertionAtPerticularPosition(int data)
        {
            if (head == null)
                head = new Node(data);
            else
            {
                Node newNode = new Node(data);

                Node ptr = head;
                int len = 0;

                while (ptr != null)
                {
                    len++;
                    ptr = ptr.next;
                }
                int count = ((len % 2) == 0) ? (len / 2) : (len + 1) / 2;
                ptr = head;

                while (count-- > 1)
                    ptr = ptr.next;

                newNode.next = ptr.next;
                ptr.next = newNode;
            }
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
<<<<<<< HEAD
                Console.WriteLine(temp.data + " ");
=======
                Console.Write(temp.data+" ");
>>>>>>> 56e307235671a734c5a6b60680626b01d36fec03
                temp = temp.next;
            }
        }

        /// <summary>
        /// Method to remove first node from a linked list
        /// </summary>
        /// <returns></returns>
        internal Node RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }

        /// <summary>
        /// Method to remove last node from linked list
        /// </summary>
        /// <returns></returns>
        internal Node RemoveLastNode()
        {
            if (this.head == null)
            {
                return null;
            }
            if (this.head.next == null)
            {
                return null;
            }
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }

        /// <summary>
        /// Method to Search node data in linked list 
        /// </summary>
        /// <param name="value">value to be search in list</param>
        /// <returns></returns>
        internal int Search(int value)
        {
            while (this.head != null)
            {
                if (this.head.data == value)
                {
                    return this.head.data;
                }
                this.head = this.head.next;
                Console.WriteLine("Search Success, {0} is present in linked list ", this.head.data);
            }
            return head.data;
        }

        /// <summary>
        /// Method to Delete the node with given key
        /// </summary>
        /// <param name="key">key values to be deleted from list</param>
        public void deleteNode(int key)
        {
            // Store head node 
            Node temp = head, prev = null;

            if (temp != null &&
                temp.data == key)
            {
                // Changed head 
                head = temp.next;
                return;
            }

            while (temp != null &&
                   temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }

            if (temp == null)
                return;

            prev.next = temp.next;
        }

        /// <summary>
        /// Method to count size of list
        /// </summary>
        /// <returns></returns>
        public int size()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }

       
    }
}
