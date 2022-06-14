using System;
using System.Collections.Generic;
using System.Linq;
using static sorting.Tools;

namespace sorting
{
    public class MergeSort
    {
        public static List<int> SortMethod(List<int> masterArr)
        {
            double n = masterArr.Count ;
            if ( n == 1)
            {
                return masterArr;
            }
            int half = (int)Math.Floor(n / 2);
            int half2 = (int)Math.Ceiling(n / 2);
            var arr1 = new List<int>(masterArr);
            arr1.RemoveRange(half, half2);

            var arr2 = new List<int>(masterArr);
            arr2.RemoveRange(0, half);

            // System.Console.WriteLine(ShowList(masterArr));
            // System.Console.WriteLine();

            // System.Console.WriteLine(ShowList(arr1));
            // System.Console.WriteLine(ShowList(arr2));
            // System.Console.WriteLine();

            arr1 = SortMethod(arr1);
            arr2 = SortMethod(arr2);

            // System.Console.WriteLine("ok" + ShowList(masterArr) + "\n");

            return Merge(arr1, arr2);
        }
        static List<int> Merge(List<int> a, List<int> b)
        {
            var c = new List<int>();
            // int temp = 100000;
            int i = 0;
            int j = 0;
            while (i < a.Count && j < b.Count)
            {
                if (b[j] < a[i])
                {
                    c.Add(b[j]);
                    j++;       
                }
                else
                {
                    c.Add(a[i]);
                    i++;
                }
                if (i >= a.Count)
                {
                    c.AddRange(b.Skip(j));
                }
                else if (j >= b.Count)
                {
                    c.AddRange(a.Skip(i));
                }
            }
            return c;
        }
    }
}