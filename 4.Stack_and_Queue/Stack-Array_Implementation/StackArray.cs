using System;
namespace Array_Implementation
{
    public class StackArray
    {
        // One dimensional array will store 
        // the elements of the stack
        private int[] stackArray;

        // Index element at top of the stack
        private int top;

        // Class constructor
        public StackArray()
        {
            // Array that contains 10 elements
            stackArray = new int[10];
            // Initialize top to -1 meaning stack is empty
            top = -1;
        }

        public StackArray(int maxSize)
        {
            stackArray = new int[maxSize];
            top = -1;
        }

        // Returns a number of elements in the stack
        public int Size()
        {
            return top + 1;
        }

        // Returns true of the stack is empty
        public bool IsEmpty()
        {
            // Stack is empty when value of top is -1 
            return (top == -1);
        }

        // Returns true if the stack is full
        public bool IsFull()
        {
            // Stack is full when top is equal to the last index of the array
            return (top == stackArray.Length - 1);
        }

        // Insert a new element on top of the stack
        public void Push(int x)
        {
            // Check if stack is full
            if (IsFull())
            {
                Console.WriteLine("Stack Overflow!");
                return;
            }
            // Otherwise top is incremented by one
            top = top + 1;
            // Place the element at the index of top in the array
            stackArray[top] = x;
        }

        // Delete an element from the top of the stack
        public int Pop()
        {
            int x;
            //Check if stack is empty
            if (IsEmpty())
                throw new System.InvalidOperationException("Stack overflow!");
            // Take the element from top of the stack
            x = stackArray[top];
            // Decrement top
            top = top - 1;
            // Return the popped element 
            return x;
        }


        // Return the top element of the stack without removing it
        public int Peek()
        {
            // Check if stack is empty
            if (IsEmpty())
                throw new System.InvalidOperationException("Stack overlofw!");
            // Return the top element of the stack
            return stackArray[top];
        }

        // Displays all the elements of the stack
        public void Display()
        {
            // Check if stack is empty
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return;
            }
            Console.WriteLine("Stack is : ");
            // Loop through and display each element in the stack
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stackArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}