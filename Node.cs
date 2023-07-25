using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDeleteOpration
{
    internal class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
        public Node(int data, Node next)
        {
            this.data = data;
            this.next = next;
        }
    }
}
