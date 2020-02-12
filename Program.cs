using System;
using System.Linq;

namespace practice
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            var heap = new Heap();
            var arr = new []{25,10,15,17,40,23,30,35};
            foreach (var item in arr)
                heap.Add(item);
            Console.WriteLine(heap);

            foreach (var item in arr)
                heap.Remove();
            Console.WriteLine(heap);

            var list = arr.ToList();
            Heap.Heapify(list);
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
