
using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

class Program 
{
    public class Node
    {
        public int Data;
        public Node? Next;
        public Node(int value)
        {
            Data = value;
            Next = null;
        }
        public void DisplayNode()
        {
            Console.WriteLine(Data);
        }
    }

    class LinkedList
    {
        Node Head;        
        Node Tail;        
        public int Count;
        
        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }    

        // Adds element to the end (O(1) because we have a previous node
        // saving the reference to the last one)
        public void InsertBackConstantTime(int value)
        {
            // creates newNode and sets value
            Node newNode = new Node(value);

            //  if head is null means the linked list is empty and sets
            //  the head to first element.
            //  else -> points the tail element to new one
            if (Head is null)            
                Head = newNode; 
            else            
                Tail.Next = newNode;        

            // now the tail pointer is the just created element
            Tail = newNode;
            // points lastElement Next property to null
            // newNode.Next = null;           
            // increments count for number of elements
            Count++;
        }

        // iterates the linked list until reach the last element
        // and assign the newNode. O(n) because loops the entire list
        // (there's no need for a tail pointer in this approach)
        public void InserBackLinearTime(int value)
        {
            // creates newNode and sets value
            Node newNode = new Node(value);
            // creates temporary node to iterate the list
            Node temp = Head;
            // loops throught the list while it is the 
            // last - 1 element
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            // points the last element to the newNode
            // which is the newest last element
            temp.Next = newNode;   

            // increments count for number of elements
            Count++;         
        }

        // Adds element to front - O(1)
        public void InsertFront(int value)
        {
            // creates newNode and sets value
            Node newNode = new Node(value);

            if (Head is null)
                Head = newNode;
            else
            {
                // creates temporary node to save the reference to the current head 
                Node temp = Head;
                // points newNode.next to the current head (new second element)     
                newNode.Next = temp;            
                // set head as the just created node
                Head = newNode;
            }
            
            // increases number of elements
            Count++;
        }

        // removes first element of the list
        public void DeleteFront()
        {
            // checks whether the list is empty
            if (Head is null)
            {
                Console.WriteLine("Empty Linked List");
                return;
            }
            // points head to next element of the list
            Head = Head.Next;
            // decreases count for number of elements
            Count--;
        }

        // removes last element of the list (needs to check)
        public void DeleteBack()
        {
            // checks whether the list is empty
            if (Head is null)
            {
                Console.WriteLine("Empty Linked List");
                return;
            }

            Node current = Head;
            Node previous = Head;

            while (current != null)
            {
                previous = current;
                current = current.Next;
            }

            previous.Next = null;

            Count--;
        }

        // searches a value on the linked list - O(n)
        public bool Search(int value)
        {
            // checks whether the list is empty
            if (Head is null)
            {
                Console.WriteLine("Empty Linked List");
                return false;
            }
            // creates new node to loop the list            
            Node runner = Head;
            // loops the list searching for the given value
            while (runner != null)
            {
                if (runner.Data == value)
                    return true;
                runner = runner.Next;
            }
            return false;
        }

        // prints the linked list - O(n)
        public void Print()
        {
            if (Head is null)
            {
                Console.WriteLine("Empty Linked List");
                return;
            }

            Node runner = Head;
            while (runner != null)
            {                
                if (runner.Next == null)                    
                    Console.WriteLine($"{runner.Data}");
                else
                    Console.Write($"{runner.Data} -> ");
                
                runner = runner.Next;
            }            
        }
    }

    public static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();

        linkedList.InsertFront(100);
        linkedList.InserBackLinearTime(200);
        linkedList.InsertFront(333);
        linkedList.InserBackLinearTime(212);
        linkedList.InsertFront(456);
        linkedList.InserBackLinearTime(256);
        linkedList.InsertFront(400);
        linkedList.InsertFront(500);

        Console.WriteLine($"Number of elements: {linkedList.Count}");
        linkedList.Print();

        Console.WriteLine(linkedList.Search(256));

        // linkedList.DeleteBack();
        // // linkedList.DeleteBack();
        // linkedList.Print();

        // linkedList.DeleteFront();
        // linkedList.DeleteFront();
        // linkedList.Print();

        // linkedList.InsertBack(5123);
        // linkedList.InsertBack(233);
        // linkedList.InsertBack(24);
        // linkedList.InsertBack(4);
        // linkedList.InsertBack(12345);
        // linkedList.InsertBack(99);
        // linkedList.InsertBack(32);

        // linkedList.InsertFront(5123);
        // linkedList.InsertFront(233);
        // linkedList.InsertFront(24);
        // linkedList.InsertFront(4);
        // linkedList.InsertFront(12345);
        // linkedList.InsertFront(99);
        // linkedList.InsertFront(32);

        // linkedList.InsertFront(100);
        // linkedList.InsertFront(200);
        // linkedList.InsertBack(300);
        
        // linkedList.Print();
        // Console.WriteLine($"Number of elements: {linkedList.Count}");

        // linkedList.PopFront();
        // linkedList.PopFront();
        // linkedList.PopFront();

        // linkedList.Print();
        // Console.WriteLine($"Number of elements: {linkedList.Count}");
                      
    }
}