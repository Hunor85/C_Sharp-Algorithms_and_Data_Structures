using System;

namespace Searching
{
    class Program
    {
		public static int Search(int[] a, int n, int searchValue)
		{
			for (int i = 0; i < n; i++)
			{
				if (a[i] == searchValue)
				{
					return i;
				}
			}
			return -1;
		}

		static void Main(string[] args)
        {
            int i, n, searchValue, index;
            int[] a = null;
            Console.WriteLine("Enter the number of elements : ");
            n = Convert.ToInt32(Console.ReadLine());

            a = new int[n];

            Console.WriteLine("Enter the elements : ");
            for (i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the search value : ");
            searchValue = Convert.ToInt32(Console.ReadLine());

            index = Search(a, n, searchValue);

            if (index >= 0)
            {
                Console.WriteLine("Value " + searchValue + "found at position " + index);
            }
            else
            {
                Console.WriteLine("Value " + searchValue + "not found");
            }
        }
    }
}
