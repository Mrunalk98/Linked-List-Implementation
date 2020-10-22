﻿using System;

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
            linkedList.InsertDataAtParticularPosition(2, 40);
            linkedList.Search(30);
            linkedList.Pop();
            linkedList.PopLast();
        }
    }
}
