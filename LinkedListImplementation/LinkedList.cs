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
            Node node = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("\nInvalid Position");
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
            Node temp = this.head;
            this.head = temp.next;
            Display();
        } 
    }
}
