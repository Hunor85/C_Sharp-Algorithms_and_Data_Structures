using System;

namespace Heap_sort
{
    class Program
    {
        public static void Sort(int[] a, int n)
        {
            BuildHeap_BottomUp(a, n);

            int maxValue;
            while (n > 1)
            {
                maxValue = a[1];
                a[1] = a[n];
                a[n] = maxValue;
                n--;
                RestoreDown(1, a, n);
            }
        }

        public static void BuildHeap_BottomUp(int[] arr, int n)
        {
            int i;
            for (i = n / 2; i >= 1; i--)
                RestoreDown(i, arr, n);
        }


        private static void RestoreDown(int i, int[] a, int n)
        {
            int k = a[i];
            int lchild = 2 * i, rchild = lchild + 1;

            while (rchild <= n)
            {
                if (k >= a[lchild] && k >= a[rchild])
                {
                    a[i] = k;
                    return;
                }
                else if (a[lchild] > a[rchild])
                {
                    a[i] = a[lchild];
                    i = lchild;
                }
                else
                {
                    a[i] = a[rchild];
                    i = rchild;
                }
                lchild = 2 * i;
                rchild = lchild + 1;
            }

            /*if number of nodes is even*/
            if (lchild == n && k < a[lchild])
            {
                a[i] = a[lchild];
                i = lchild;
            }
            a[i] = k;
        }
        static void Main(string[] args)
        {
            int i, n;
            int[] a = new int[20];

            Console.Write("Enter the nemuber of elements: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.Write("Enter element " + i  + " : ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Sort(a, n);

            Console.WriteLine("Sorted array is: ");
            for (i = 1; i <= n; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }
    }
}
