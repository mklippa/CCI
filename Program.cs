using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            Console.WriteLine(queue);

            var length = queue.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(queue.Dequeue());
                Console.WriteLine(queue);
            }
        }
    }
}
