using System.Collections.Generic;
using System.Linq;
using System;

namespace sorting
{
    public class InsertionSort
    {
        public static List<int> SortMethod(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                // for (int j = 0; j < i; j++)
                // {
                //     if (list[i] < list[j])
                //     {
                //         list.Insert(j, list[i]);
                //         list.RemoveAt(i + 1);
                //     }
                // }
                int current = list[i];
                int j = i -1;
                while (j >= 0 && current < list[j])
                {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j + 1] = current;
            }
            return list;
        }
    }
}