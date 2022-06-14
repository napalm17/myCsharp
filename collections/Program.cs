using System;
using System.Collections.Generic;
using System.Linq;
namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays();
            Lists();
        }
        static void Lists()
        {
            var l = new List<int>() {1, 1, 1, 1, 1, 1, 1};
            // l.Add(18);
            // l.Insert(0, 6);
            // l.Sort();
            // l.Reverse();
            // l.Remove(9);
            // l.RemoveAt(3);
            // l.Clear();
            var a = l.Contains(12);
            var b = l.IndexOf(12);            
            // for (int i = 0; i < l.Count; i++) 
            // {
            //     System.Console.WriteLine(l[i]);
            //}
            foreach (int elem in l)
            {
                System.Console.WriteLine(elem);
            }
            System.Console.WriteLine(String.Join(" ", l.Distinct()));
            System.Console.WriteLine(l.Distinct().Skip(1).Any());
            //System.Console.WriteLine(l[^1]); // only with dotnet run!
            var r = Enumerable.Range(0, 100);
            var rangeArr = r.ToArray();
            // foreach (int elem in r)
            // {
            //     System.Console.WriteLine(elem);
            // }

            // var archList = new List<List<int>>()
            // {
            //     new List<int>{10, 11, 12},
            //     new List<int>{20, 21, 22, 23},
            //     new List<int>{30, 31, 32, 33, 34}
            // };
            
            // foreach (List<int> list in archList)
            // {
            //     foreach (int elem in list)
            //     {
            //         System.Console.Write(elem + " ");
            //     }
            //     System.Console.WriteLine();
                
            // }
        }

        static void Arrays()
        {
            // int[] arr1 = new int[10];
            // //arr1[0] = 10;
            
            // for (int i = 0; i < arr1.Length; i++)
            // {
            //     arr1[i] = i;
            // }
            // for (int i = 0; i < arr1.Length; i++)
            // {
            //     Console.Write($"{arr1[i]}, ");
            // }

            // int[] arr2 = {44, 32, 90, 25, 11};
            // System.Console.WriteLine(Array.IndexOf(arr2, 11));
            // Array.Sort(arr2);
            // Array.Reverse(arr2);

            int[,] arr2dim = new int[3, 3] {
                {1, 2, 1},
                {3, 1, 3},
                {1, 2, 1}
                };
            //System.Console.WriteLine(arr2dim[1,1]);
            int[][] arrJagged = {
                new int[]{1, 2, 1},
                new int[]{3, 1, 3, 5, 2, 0, 9},
                new int[]{1, 2}
                };
            //System.Console.WriteLine(arrJagged[1][5]);
            for (int i = 0; i < arrJagged.Length; i++)
            {
                for (int j = 0; j < arrJagged[i].Length; j++)
                {
                    System.Console.Write(arrJagged[i][j] + " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
