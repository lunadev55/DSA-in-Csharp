
using System;
using System.Linq.Expressions;
using System.Security;
using System.Security.Cryptography.X509Certificates;

class Program 
{
    public class Node
    {
        public int Data;
        public Node? Next;
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class Stack
    {
        public Node Top;
        public int Count;

        public Stack()
        {
            Top = null;
            Count = 0;
        }

        public void Push(int value)
        {
            // creates newNode to be added to the top of the stack
            Node newNode = new Node(value);
            // points new node Next property to the previous top 
            newNode.Next = Top;
            // points top to the new node
            Top = newNode;           
            // increments number of elements
            Count++;
        }

        public void Pop()
        {
            // checks if the stack is empty
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty!");
                return;
            }
            // if not, points top to the next element in the stack
            Top = Top.Next;                
            // decreases number of elements
            Count--;
        }
        
        private bool IsEmpty()
        {
            return Top is null;
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty!");
                return;
            }
            // creates new node pointer to Top so we can loop the stack
            Node runner = Top;
            // loops the stack until last element
            while (runner is not null)
            {
                Console.WriteLine(runner.Data);
                runner = runner.Next;
            }
        }

    }
        

    public static void Main(string[] args)
    {
        Stack stack = new Stack();

        Console.WriteLine("Stack Implementation :)");

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);
        stack.Push(6);
        stack.Push(7);
        stack.Push(8);

        stack.Pop();
        stack.Pop();
        stack.Pop();
        
        stack.Print();                      
    }
}