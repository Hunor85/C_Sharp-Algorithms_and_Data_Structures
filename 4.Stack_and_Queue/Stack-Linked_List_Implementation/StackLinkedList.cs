using System;
namespace Linked_List_Implementation
{
    // The class implementing stack using link
    public class StackLinkedList
    {
        // Reference to the first element of the list
        private Node top;

        // Constructore initializes top to null
        // If top is null stack is empty
        public StackLinkedList()
        {
            top = null;
        }

        // Return a number of elements from the stack
        public int Size()
        {
            // Traverse the linked list 
            // and count the number of nodes
            int s = 0;
            Node p = top;
            while (p != null)
            {
                p = p.link;
                s++;
            }
            return s;
        }


        // Insert new element in the beginning in the linked list
        public void Push(int x)
        {
            Node temp = new Node(x);
            temp.link = top;
            top = temp;
        }

        // Delete the first element of the linked list
        // Check if stack is empty
        public int Pop()
        {
            int x;
            if ( IsEmpty())
                throw new System.InvalidOperationException("Stack Overflow!");
            x = top.info;
            top = top.link;
            return x;
        }

        // Return the info part of the linked list
        // Check if stack is empty
        public int Peek()
        {
            if ( IsEmpty())
                throw new System.InvalidOperationException("Stack Underflow!");
            return top.info;
        }

        // Check if stack is empty
        public bool IsEmpty()
        {
            return ( top == null ); 
        }

        // Display all the elements of the stack
        public void Display()
        {
            Node p = top;
            if ( IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            Console.WriteLine("Stack is : ");
            while (p != null)
            {
                Console.WriteLine(p.info + " ");
                p = p.link;
            }

            Console.WriteLine();
        }
    }
}
