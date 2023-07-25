using System;
using System.Collections.Generic;

namespace LinkedListDeleteOpration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListDe listObj = new LinkedListDe();

            listObj.InsertFirst(3);
            listObj.InsertFirst(9);
            listObj.InsertFirst(6);


            listObj.InsertLast(98);
            listObj.InsertLast(56);


            listObj.Insert(100, 2);

            listObj.Display();
            Console.WriteLine(listObj.DeleteFirst());

            listObj.Display();
            Console.WriteLine(listObj.DeleteLast());
            listObj.Display();

            Console.WriteLine(listObj.Delete(1));
            listObj.Display();


        }
    }
}
