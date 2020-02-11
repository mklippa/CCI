using System.Linq;

namespace practice
{
    public partial class Program
    {
        public static bool BinarySearch(int[] arr, int key)
        {
            if (arr.Length == 0)
                return false;
            if (arr.Length == 1)
                return arr[0] == key;

            var middle = arr.Length / 2;
            if (arr[middle] == key)
                return true;
            if (arr[middle] > key)
                return BinarySearch(arr.Take(middle).ToArray(), key);
            else
                return BinarySearch(arr.Skip(middle).ToArray(), key);
        }
    }
}