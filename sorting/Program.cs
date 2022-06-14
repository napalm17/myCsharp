using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;



namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 10000000;
            var unsorted = Tools.GenerateShuffledList(range: 100000, length: length);
            
            var watch = new Stopwatch();
            watch.Start();
            int[] unsortedArr = new int[length];
            unsorted.CopyTo(unsortedArr);
            var sorted = MergeSortCopy.SortMethod(unsortedArr, 0, unsortedArr.Length -1);
            watch.Stop();
            var elapsed1 = watch.ElapsedMilliseconds;
            System.Console.WriteLine(elapsed1);


            var watch2 = new Stopwatch();
            watch2.Start();
            var sorted2 = MergeSort.SortMethod(new List<int>(unsorted));
            watch2.Stop();

            var elapsed2 = watch2.ElapsedMilliseconds;
            System.Console.WriteLine(elapsed2);
            
            // var sorted = SelectionSort.SortMethod(new List<int>(unsorted));

            // var sorted = InsertionSort.SortMethod(new List<int>(unsorted));

            // var sorted = BubbleSort.SortMethod(new List<int>(unsorted));

            // var sorted = QuickSort.QuickSortMethod(new List<int>(unsorted), new List<int>());

            // var sorted = HeapSortCopy.SortMethod(new List<int>(unsorted));
            
            // var sorted2 = HeapSort.SortMethod(new List<int>(unsorted), new List<int>());  
            
            // System.Console.WriteLine(Tools.ShowList(unsorted));
            // System.Console.WriteLine(String.Join(", ", sorted));


        }
    }
}
