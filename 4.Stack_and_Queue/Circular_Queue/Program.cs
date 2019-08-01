using System;

namespace Circular_Queue
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int choice, x;

            CircularQueue qu = new CircularQueue(8);

            while (true)
            {
                Console.WriteLine("1. Insert an element in the queue");
                Console.WriteLine("2. Delete an element from the queue");
                Console.WriteLine("3. Display element at the front");
                Console.WriteLine("4. Display all elements of the queue");
                Console.WriteLine("5. Display the size of the queue");
                Console.WriteLine("6. Quit");
                Console.WriteLine("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6)
                    break;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the element to be inserted: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        qu.Insert(x);
                        break;
                    case 2:
                        x = qu.Delete();
                        Console.Write("Element deleted is: " + x);
                        break;
                    case 3:
                        Console.Write("Element at the front is: " + qu.Peek());
                        break;
                    case 4:
                        qu.Display();
                        break;
                    case 5:
                        Console.Write("Size of the queue: " + qu.Size());
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
