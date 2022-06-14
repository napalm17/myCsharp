using System.Collections.Generic;
using System.Linq;
using System;

namespace sorting
{
    public class QuickSort
    {
        public static List<int> Quick(List<int> masterList, List<int> sorted)
        {
            Random rand = new Random();
            int pivot = masterList[rand.Next(masterList.Count)];
            var list1 = new List<int>();
            var list2 = new List<int>();

            for (int i = 0; i < masterList.Count; i++)
            {
                if (masterList[i] <= pivot)
                {
                    list1.Add(masterList[i]);
                }
                else
                {
                    list2.Add(masterList[i]);
                }
            }
            foreach (var list in new List<List<int>>(){list1, list2})
            {
                if (Tools.IsSorted(list)) 
                {
                    sorted.AddRange(list); 
                }
                else
                {
                    Quick(list, sorted);
                }
            }
            return sorted;
        }
        public static List<int> SortMethod(List<int> masterList)
        {
            var sorted = new List<int>(){};
            Quick(masterList, sorted);
            return sorted;
        }

    }
}