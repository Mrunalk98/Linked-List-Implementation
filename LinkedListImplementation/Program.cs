using System;

namespace LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Implementatiion!");
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();
            int position = linkedList.Search(30);
            if (position > 0)
                linkedList.InsertDataAtParticularPosition(position, 40);
            linkedList.Remove(40);
            int size = linkedList.Size();
            Console.WriteLine("\nSize of Linked list : " + size);
        }
    }
}
