using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Console_App.Microsoft
{
    public class SearchElementSortedAndRotatedArray
    {
        public static void Client()
        {
            int[] arr = { 4, 5, 6, 7, 8, 9, 1, 2, 3 };
            int n = arr.Length;
            int key = 6;
            int i = SearchElementArray.search(arr, 0, n - 1, key);

            if (i != -1)
                Console.WriteLine("Index: " + i);
            else
                Console.WriteLine("Key not found");
        }
    }

    static class SearchElementArray
    {
        public static int search(int[] arr, int l, int h,
                      int key)
        {
            if (l > h)
                return -1;

            int mid = (l + h) / 2;

            if (arr[mid] == key)
                return mid;

            /* If arr[l...mid] is sorted */
            if (arr[l] <= arr[mid])
            {

                /* As this subarray is sorted, we
                can quickly check if key lies in
                half or other half */
                if (key >= arr[l] && key <= arr[mid])
                    return search(arr, l, mid - 1, key);

                return search(arr, mid + 1, h, key);
            }

            /* If arr[l..mid] is not sorted,
            then arr[mid... r] must be sorted*/
            if (key >= arr[mid] && key <= arr[h])
                return search(arr, mid + 1, h, key);

            return search(arr, l, mid - 1, key);
        }
    }
}
