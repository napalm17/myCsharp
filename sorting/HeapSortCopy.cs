using System.Collections.Generic;
using System.Linq;
using System;

namespace sorting
{
    public class HeapSortCopy
    {

        public static List<int> SortMethod(List<int> arr)
        {
            int n = arr.Count;
    
            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);
    
            // One by one extract an element from heap
            for (int i = n - 1; i > 0; i--) {
                // Move current root to end
                Tools.SwapItems(arr, 0, i);
    
                // call max heapify on the reduced heap
                heapify(arr, i, 0);
            }

            return arr;
        }
        public static void heapify(List<int> arr, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;
    
            if (l < n && arr[l] > arr[largest])
                largest = l;
    
            if (r < n && arr[r] > arr[largest])
                largest = r;
    
            if (largest != i) {
                Tools.SwapItems(arr, i, largest);
                heapify(arr, n, largest);
            }
        }
    }
}