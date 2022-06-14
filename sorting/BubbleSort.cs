using System.Collections.Generic;
using System.Linq;
using System;

namespace sorting
{
    public class BubbleSort
    {
        public static List<int> SortMethod(List<int> list)
        {
            bool isSorted = false;
            while (!(isSorted))
            {
                isSorted = true;
                for (int i = 0; i < list.Count  - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        Tools.SwapItems(list, i, i + 1);
                        isSorted = false;
                    }   
                }
            }
            return list;
        }
    }
}