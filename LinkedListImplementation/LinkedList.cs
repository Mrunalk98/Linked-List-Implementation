﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListImplementation
{
    public class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(node.data + " inserted into linked list");
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            Console.WriteLine("\nData present in Linked List : ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        internal void InsertDataAtParticularPosition(int position, int data)
        {
            Console.WriteLine("\nAfter Inserting " + data + " at position " + position + " in Linked List");
            Node node = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            if (position == 1)
            {
                node.next = this.head;
                head = node;
                Display();
                return;
            }
            Node current = this.head;
            Node prev = null;

            
            for (int i = 1; i < position; i++)
            {
                prev = current;
                current = current.next;

                if (current == null)
                {
                    break;
                }               
            }

            node.next = current;
            prev.next = node;
            Display();
        }

        internal void Pop()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            this.head = this.head.next;
            Display();
        } 

        internal void PopLast()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            if (this.head.next == null)
            {
                this.head = null;
                Display();
                return;
            }
            Node temp = this.head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
            Display();
        }

        internal void Remove(int data)
        {
            Console.WriteLine("\nAfter Removing " + data + " from Linked List");
            if (this.head == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            Node temp = this.head;
            while (temp.next != null)
            {
                if (temp.next.data == data)
                {
                    temp.next = temp.next.next;
                    Display();
                    return;
                }
                temp = temp.next;
            }
            Console.WriteLine("Element not found");
            return;
        }
        internal int Search(int data)
        {
            Console.WriteLine("\nTo Search " + data + " in Linked List");
            if (this.head == null)
            {
                Console.WriteLine("Linked list is empty");
                return 0;
            }
            Node temp = this.head;
            int i = 1;
            while(temp != null)
            {
                if (temp.data == data)
                {
                    Console.WriteLine(data + " found at position " + i);
                    return (i+1);
                }
                temp = temp.next;
                i++;
            }
            Console.WriteLine("Element not found");
            return 0;

        }

        internal int Size()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked list is empty");
                return 0;
            }
            Node temp = this.head;
            int i = 0;
            while (temp != null)
            {
                temp = temp.next;
                i++;
            }
            return i;
        }
    }
}
