using System;

namespace Linked_List_Implementation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int choice, x;

            StackLinkedList stack = new StackLinkedList();

            while (true)
            {
                Console.WriteLine("1. Push element on the stack");
                Console.WriteLine("2. Pop an element from the stack");
                Console.WriteLine("3. Display the top element");
                Console.WriteLine("4. Display all the satck elements");
                Console.WriteLine("5. Display the size of the stack");
                Console.WriteLine("6. Quit"); 
                Console.WriteLine("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6)
                    break;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the element to be pushed: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        stack.Push(x);
                        break;
                    case 2:
                        x = stack.Pop();
                        Console.Write("Popped element is: " + x);
                        break;
                    case 3:
                        Console.Write("Element at the top is: " + stack.Peek());
                        break;
                    case 4:
                        stack.Display();
                        break;
                    case 5:
                        Console.Write("Size of the stack: " + stack.Size());
                        break;
                    default:
                        Console.Write("Bad choice");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
