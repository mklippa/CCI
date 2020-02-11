using System;
using System.Collections.Generic;
using System.Linq;

namespace practice
{
    public partial class Program
    {
        private static Random _rnd = new Random();
        public static int[] QuickSort(int[] arr)
        {
            if (arr.Length < 2)
                return arr;
            var pivot_indx = _rnd.Next(0, arr.Length);
            var pivot = arr[pivot_indx];
            var less = new List<int>();
            var greater = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == pivot_indx) continue;
                if (arr[i] <= pivot)
                    less.Add(arr[i]);
                else
                    greater.Add(arr[i]);
            }
            return QuickSort(less.ToArray())
            .Concat(new[] { pivot })
            .Concat(QuickSort(greater.ToArray()))
            .ToArray();
        }

        private static void Print<T>(IEnumerable<T> arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}