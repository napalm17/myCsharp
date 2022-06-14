using System;
using System.Collections.Generic;
using System.Linq;

namespace sorting
{
    public class Tools
    {
        public static string ShowList(List<int> list)
        {
            return "{ " + String.Join(", ", list) + " }";
        }
        
        public static void SwapItems(List<int> list, int index1, int index2)
        {
            int tmp = list[index1];
            list[index1] = list[index2];
            list[index2] = tmp;
        }

        public static List<int> GenerateShuffledList(int range=10, int length=10)
        {
            var shuffled = new List<int>();
            var rand = new Random();
            for (int i = 0; i < length; i++)
            {
                shuffled.Add(rand.Next(range));
            }
            return shuffled;
        }

        public static bool IsSorted(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}