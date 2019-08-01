using System;

namespace Binary_tree_sort
{
    class Program
    {
        public static void Sort(int[] a, int n)
        {
            BinarySearchTree tree = new BinarySearchTree();

            for (int i = 0; i < n; i++)
                tree.Insert(a[i]);

            tree.Inorder(a);
        }
        static void Main(string[] args)
        {
            int i, n;
            int[] a = new int[20];

            Console.Write("Enter the nemuber of elements: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("Enter element " + (i + 1) + " : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Sort(a, n);

            Console.WriteLine("Sorted array is: ");
            for (i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }
    }
}
