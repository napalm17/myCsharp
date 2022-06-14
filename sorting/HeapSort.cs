using System.Collections.Generic;
using System.Linq;
using System;

namespace sorting
{
    public class HeapSort
    {

        public static List<int> Heapify(List<int> unsorted)
        {   
            unsorted.Insert(0, 0);
            int limit = (int)Math.Floor((double)(unsorted.Count - 1) / 2);
            for (int i = limit; i > 0; i--)
            {
                int parent = unsorted[i];
                int child1 = unsorted[2*i];
                int child2;
                try
                {
                    child2 = unsorted[2*i+1];
                }
                catch (ArgumentOutOfRangeException)
                {
                    child2 = child1 - 1;
                }
    
                if (child1 > parent && child1 > child2)
                {
                    Tools.SwapItems(unsorted, i, 2*i);
                }
                else if (child2 > parent)
                {
                    Tools.SwapItems(unsorted, i, 2*i+1);
                }
            }
            return unsorted;
        }

        public static List<int> SortMethod(List<int> unsorted, List<int> sorted)
        {
            var newList = new List<int>(Heapify(unsorted));
            newList.RemoveAt(0);

            int maxItem = newList[0];
            newList.RemoveAt(0);
            sorted.Insert(0, maxItem);
            
            int lastItem = newList.Last();
            newList.RemoveAt(newList.Count - 1);
            newList.Insert(0, lastItem); 

            if (newList.Count == 1)
            {
                sorted.Insert(0, newList[0]);
                return null;
            }
            SortMethod(newList, sorted);
            return sorted;
        }
    }
}