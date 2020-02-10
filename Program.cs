using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new ArrayList<int>();

            arr.Add(0);
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);

            Console.WriteLine(arr);

            Console.WriteLine(arr.Get(0));
            Console.WriteLine(arr.Get(1));
            Console.WriteLine(arr.Get(2));
            Console.WriteLine(arr.Get(3));

            arr.RemoveAt(1);
            Console.WriteLine(arr);
            
            arr.RemoveAt(0);
            Console.WriteLine(arr);
            
            arr.RemoveAt(1);
            Console.WriteLine(arr);
            
            arr.RemoveAt(0);
            Console.WriteLine(arr);
        }
    }
}
