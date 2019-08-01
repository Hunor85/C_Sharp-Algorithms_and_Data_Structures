using System;
namespace Searching
{
    public class Searching
    {
        public int Search(int[] a, int n, int searchValue)
        {
            int first = 0, last = n - 1, mid;
            while (first <= last)
            {
                mid = (first + last) / 2;

                if (searchValue < a[mid])
                {
                    last = mid - 1;
                }
                else if (searchValue > a[mid])
                {
                    first = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }

        public int Search(int[] a, int first, int last, int searchValue)
        {
            if (first > last)
            {
                return -1;
            }
            int mid = (first + last) / 2;
            if (searchValue > a[mid])
                return Search(a, mid + 1, last, searchValue);
            else if (searchValue < a[mid])
                return Search(a, first, mid - 1, searchValue);
            else
                return mid;
        }
    }
}
