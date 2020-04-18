using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    class linkedList
    {
        public Node head;
        Node current;
        public linkedList(int val)
        {
            head = new Node(val);
            current = head;
        }
        public Node getNext()
        {
            current = current.next;
            return current;
        }
        public linkedList Add(int val)
        {
            var new_node = new Node(val);
            while(Node )
            return this;

        }

    }
    class Node
    {
        public int val;
        public Node next=null;
        public Node(int a)
        {
            val = a;
        }
    }
}
