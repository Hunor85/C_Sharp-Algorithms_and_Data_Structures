using System;

namespace Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bt = new BinarySearchTree();
            int choice, x;
            while (true)
            {
                Console.WriteLine("1 - Display Tree");
                Console.WriteLine("2 - Search");
                Console.WriteLine("3 - Insert a new Node");
                Console.WriteLine("4 - Delete a node");
                Console.WriteLine("5 - PreOrder traversal");
                Console.WriteLine("6 - InOrder traversal");
                Console.WriteLine("7 - PostOrder traversal");
                Console.WriteLine("8 - Tree Height");
                Console.WriteLine("9 - Find minimum key");
                Console.WriteLine("10 - Find maximum key");
                Console.WriteLine("99 - Quit");
                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 99)
                    break;
                switch (choice)
                {
                    case 1:
                        {
                            bt.Display();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter the key to be searched : ");
                            x = Convert.ToInt32(Console.ReadLine());
                            if (bt.Search(x))
                                Console.WriteLine("key founded!");
                            else
                                Console.WriteLine("key not founded!");
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Enter the key to be inserted : ");
                            x = Convert.ToInt32(Console.ReadLine());
                            bt.Insert(x);
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Enter the key to be deleted : ");
                            x = Convert.ToInt32(Console.ReadLine());
                            bt.Delete(x);
                            break;
                        }
                    case 5:
                        {
                            bt.PreOrder();
                            break;
                        }
                    case 6:
                        {
                            bt.InOrder();
                            break;
                        }
                    case 7:
                        {
                            bt.PostOrder();
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Tree height is : " + bt.Height());
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Minimum key is : " + bt.Min());
                            break;
                        }
                    case 10:
                        {
                            Console.WriteLine("Maximum key is : " + bt.Max());
                            break;
                        }
                    default:
                        break;
                }
            }
        }     
    }
}
