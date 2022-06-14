using System;
using System.Collections.Generic;
using System.Linq;
using static sorting.Tools;

namespace sorting
{
    public class MergeSortCopy
    {
        public static void merge(int[] arr, int l, int m, int r)
    {
        int n1 = m - l + 1;
        int n2 = r - m;
        int[] L = new int[n1];
        int[] R = new int[n2];
        int i, j;

        for (i = 0; i < n1; ++i)
            L[i] = arr[l + i];
        for (j = 0; j < n2; ++j)
            R[j] = arr[m + 1 + j];
        i = 0;
        j = 0;
        int k = l;
        while (i < n1 && j < n2) {
            if (L[i] <= R[j]) {
                arr[k] = L[i];
                i++;
            }
            else {
                arr[k] = R[j];
                j++;
            }
            k++;
        }
        while (i < n1) {
            arr[k] = L[i];
            i++;
            k++;
        }

        while (j < n2) {
            arr[k] = R[j];
            j++;
            k++;
        }
    }
 

    public static int[] SortMethod(int[] arr, int l, int r)
    {
        if (l < r) {
            int m = l+ (r-l)/2;
            SortMethod(arr, l, m);
            SortMethod(arr, m + 1, r);
            merge(arr, l, m, r);
        }
        return arr;
    }
    }
}