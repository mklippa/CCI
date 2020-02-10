using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(stack);

            var length = stack.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack);
            }
        }
    }
}
