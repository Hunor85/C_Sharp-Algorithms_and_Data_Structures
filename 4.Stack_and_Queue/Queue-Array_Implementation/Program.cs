using System;

namespace Queue_Array_Implementation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int choice, x;

            QueueArray queue = new QueueArray(8);

            while (true)
            {
                Console.WriteLine("1. Insert an element in the queue");
                Console.WriteLine("2. Delete an element from the queue");
                Console.WriteLine("3. Display element at the front");
                Console.WriteLine("4. Display all elements if the queue");
                Console.WriteLine("5. Display size of the queue");
                Console.WriteLine("6. Quit");
                Console.WriteLine("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 6)
                    break;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the element to be inserted: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        queue.Insert(x);
                        break;
                    case 2:
                        x = queue.Delete();
                        Console.WriteLine("Element deleted is: " + x);
                        break;
                    case 3:
                        Console.WriteLine("Element at the front is: " + queue.Peek());
                        break;
                    case 4:
                        queue.Display();
                        break;
                    case 5:
                        Console.WriteLine("Size of queue is " + queue.Size());
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
