using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDeleteOpration
{
    internal class LinkedListDe
    {
        public Node head;
        public Node tail;
        int size;
        public LinkedListDe()
        {
            this.size = 0;
        }

        public void InsertFirst(int data)
        {
            Node node = new Node(data);

            node.next = head;
            head = node;

            if(tail == null)
            {
                tail = head;
            }
            size += 1;
        }

        public void Display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " -->");
                temp = temp.next;
            }
            Console.WriteLine("end");


        }


        public void InsertLast(int data)
        {
            if(tail == null)
            {
                InsertFirst(data);
                return;
            }


            Node node = new Node(data);

            tail.next = node;
            tail = node;
            size += 1;
        }


        public void Insert(int data, int index)
        {
            if (index == 0)
            {
                InsertFirst(data);
                return;
            }

            if (index == size)
            {
                InsertLast(data);
                return;
            }

            Node temp = head;
            for (int i = 0; i < index; i++)
            {
                temp = temp.next;
            }
            Node node = new Node(data, temp.next);
            temp.next = node;
            size += 1;
        }

        public int DeleteFirst()
        {
            int data = head.data;
            head = head.next;
            if(head == null)
            {
                tail = null;

            }
            size--;
            return data;
        }



        public Node Get(int index) { 
            Node node = head;
            for(int i = 0; i < index; i++)
            {
                node = node.next;
            }
            return node;
        }
        public int DeleteLast()
        {
            if(size <= 1)
            {
                return DeleteFirst();
            }

            Node secondLast = Get(size - 2);

            int data = tail.data;
            tail = secondLast;
            tail.next = null;
            return data;
        }



        public int Delete(int index) {
            if(index == 0)
            {
                return DeleteFirst();
            }
            if(index == size - 1)
            {
                return DeleteLast();
            }

            Node prev = Get(index - 1);
            int data = prev.next.data;
            prev.next = prev.next.next;
            return data;
        }


        








    }
}
