using System.Collections.Generic;
using System.Linq;
using System;

namespace sorting
{
    public class SelectionSort
    {
        public static List<int> SortMethod(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int minId = i;
                for (int j = i + 1; j < list.Count ; j++)
                {
                    if (list[j] < list[i] && list[j] < list[minId])
                    {
                        minId = j;
                    }
                }
                Tools.SwapItems(list, i, minId);
            }
            return list;
        }
    }
}