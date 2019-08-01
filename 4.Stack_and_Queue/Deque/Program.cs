using System;

namespace Deque
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int choice, x;

            DequeArray qu = new DequeArray(8);

            while (true)
            {
                Console.WriteLine("1. Insert at the front end");
                Console.WriteLine("2. Insert at the rear end");
                Console.WriteLine("3. Delete from front end");
                Console.WriteLine("4. Delete from rear end");
                Console.WriteLine("5. Display all elements of deque");
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
                        qu.InsertFront(x);
                        break;
                    case 2:
                        Console.Write("Enter the element to be inserted: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        qu.InsertRear(x);
                        break;
                    case 3:
                        Console.Write("Element deleted from front end is " + qu.DeleteFront());
                        break;
                    case 4:
                        Console.Write("Element deleted from rear end is " + qu.DeleteRear());
                        break;
                    case 5:
                        qu.Display();
                        break;
                    default:
                        Console.Write("Bad choice");
                        break;
                }
            }
        }
    }
}
