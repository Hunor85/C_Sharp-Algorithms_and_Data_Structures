using System;

namespace SingleLinkedList
{
    class MainClass
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int choice, data, k, x;

            LinkedList list = new LinkedList();

            //list.CreateList();
            list.CreateList();
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            list1.CreateList();
            list2.CreateList();

            list1.BubbleSortExData();
            list2.BubbleSortExData();

            Console.WriteLine("First list - "); 
            list1.DisplayList();

            Console.WriteLine("Second list - ");
            list2.DisplayList();

            LinkedList list3;

            list3 = list1.Merge1(list2);
            Console.WriteLine("Merged list - ");
            list3.DisplayList();

            Console.WriteLine("First list - ");
            list1.DisplayList();

            Console.WriteLine("Second list - ");
            list2.DisplayList();

            list3 = list1.Merge2(list2);
            Console.WriteLine("Merged list - ");
            list3.DisplayList();

            Console.WriteLine("First list - ");
            list1.DisplayList();
            Console.WriteLine("Second list - ");
            list2.DisplayList();




            while (true) {
                Console.WriteLine("1. Display list");
                Console.WriteLine("2. Count the number of nodes");
                Console.WriteLine("3. Search for an element");
                Console.WriteLine("4. Insert in empty list");
                Console.WriteLine("5. Insert node at the end of the list");
                Console.WriteLine("6. Insert node after a specified node");
                Console.WriteLine("7. Insert node before a specified node");
                Console.WriteLine("8. Insert node at a given position");
                Console.WriteLine("9. Delete first node");
                Console.WriteLine("10. Delete last node");
                Console.WriteLine("11. Delete any node");
                Console.WriteLine("12. Reverse the list");
                Console.WriteLine("13. Bubble sort by exchanging data");
                Console.WriteLine("14. Bubble sort by exchanging links");
                Console.WriteLine("15. Merge sort");
                Console.WriteLine("16. Insert cycle");
                Console.WriteLine("17. Detect cycle");
                Console.WriteLine("18. Remove cycle");
                Console.WriteLine("19. Quit");

                Console.WriteLine("Enter youc choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 19)
                    break;

                switch(choice){
                    case 1:
                        list.DisplayList();
                        break;
                   
                    case 2:
                        list.CountNodes();
                        break;
                    case 3:
                        Console.WriteLine("Enter the element to be searched for : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.Search(data);
                        break;
                    case 4:
                        Console.WriteLine("Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInBeginning(data);
                        break; 

                    case 5:
                        Console.WriteLine("Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        break; 

                    case 6:
                        Console.WriteLine("Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the element after which to be inserted : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfter(data, x);
                        break;
                    case 7:
                        Console.WriteLine("Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the element before which to be inserted : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, x);
                        break;
                    case 8:
                        Console.WriteLine("Enter the element to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the position at which to be inserted");
                        k = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtPosition(data, k);
                        break;
                    case 9:
                        list.DeleteFirstNode();
                        break;
                    case 10:
                        list.DeleteLastNode();
                        break;
                    case 11:
                        Console.WriteLine("Enter the element to be deleted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(data);
                        break;
                    case 12:
                        list.ReverseList();
                        break;

                    case 13:
                        list.BubbleSortExData();
                        break;
                    case 14:
                        list.BubbleSortExLinks();
                        break;
                    case 15:
                        list.MergeSort();
                        break;
                    /*case 16:
                        Console.WriteLine("Enter the element at which the cycle has to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertCycle(data);
                        break;*/
                }
                Console.WriteLine();
            }
            Console.WriteLine("Exiting");
        }
    }
}
