
using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

class Program 
{
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }
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
        Node Previous;        
        public int Count;
        
        public LinkedList()
        {
            Head = null;
            Previous = null;
            Count = 0;
        }    

        // Adds element to the end
        public void InsertBack(int value)
        {
            // creates newNode and sets value
            Node newNode = new Node(value);

            //  if head is null means the linked list is empty and sets
            //  the head to first element.
            //  else -> points the previous element to new one
            if (Head is null)            
                Head = newNode; 
            else            
                Previous.Next = newNode;        

            // now the previous pointer is the just created element
            Previous = newNode;
            // points lastElement Next property to null
            // newNode.Next = null;           
            // increments count for number of elements
            Count++;
        }

        // Adds element to front
        public void InsertFront(int value)
        {
            // creates newNode and sets value
            Node newNode = new Node(value);

            if (Head is null)
                Head = newNode;
            // creates temporary node to save the reference to the current head 
            Node temp = Head;
            // points newNode.next to the current head (new second element)     
            newNode.Next = temp;            
            // set head as the just created node
            Head = newNode;
            // increases number of elements
            Count++;
        }

        // removes first element of the list
        public void Pop()
        {
            // points head to next element of the list
            Head = Head.Next;
            // decreases count for number of elements
            Count--;
        }


        public void Print()
        {
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

        linkedList.InsertFront(100);
        linkedList.InsertFront(200);
        linkedList.InsertBack(300);
        
        linkedList.Print();
        Console.WriteLine($"Number of elements: {linkedList.Count}");

        linkedList.Pop();
        linkedList.Pop();
        linkedList.Pop();

        linkedList.Print();
        Console.WriteLine($"Number of elements: {linkedList.Count}");
                      
    }
}