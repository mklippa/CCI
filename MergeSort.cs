using System.Collections.Generic;
using System.Linq;

namespace practice {
    public partial class Program {
        public static int[] MergeSort(int[] arr) {
            if(arr.Length < 2)
                return arr;

            var middle = arr.Length / 2;

            var left = MergeSort(arr.Take(middle).ToArray());
            var right = MergeSort(arr.Skip(middle).ToArray());

            var result = new List<int>();
            var left_index = 0;
            var right_index = 0;
            while(true) {
                // all sorted
                if (left_index == left.Length && right_index == right.Length)
                    break;
                // left completed
                if (left_index == left.Length) {
                    result.Add(right[right_index]);
                    right_index++;
                }
                // right completed
                else if (right_index == right.Length) {
                    result.Add(left[left_index]);
                    left_index++;
                }
                // left less or equal than right
                else if (left[left_index] <= right[right_index])
                {
                    result.Add(left[left_index]);
                    left_index++;
                // right less than left
                } else {
                    result.Add(right[right_index]);
                    right_index++;
                }
            }

            return result.ToArray();
        }
    }
}