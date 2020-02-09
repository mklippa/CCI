using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList1 = new SinglyLinkedList<int>();
            linkedList1.Append(1);
            Console.WriteLine(linkedList1);
            linkedList1.Append(3);
            Console.WriteLine(linkedList1);

            linkedList1.InsertTo(0, 0);
            Console.WriteLine(linkedList1);
            linkedList1.InsertTo(2, 2);
            Console.WriteLine(linkedList1);
            linkedList1.InsertTo(4, 4);
            Console.WriteLine(linkedList1);

            Console.WriteLine();

            var linkedList2 = new SinglyLinkedList<int>();
            linkedList2.Append(1);
            linkedList2.Append(2);
            linkedList2.Append(3);
            linkedList2.Append(4);
            Console.WriteLine(linkedList2);
            
            linkedList2.Remove(1);
            Console.WriteLine(linkedList2);
            linkedList2.Remove(3);
            Console.WriteLine(linkedList2);
            linkedList2.Remove(4);
            Console.WriteLine(linkedList2);
            linkedList2.Remove(2);
            Console.WriteLine(linkedList2);

            Console.WriteLine();

            var linkedList3 = new SinglyLinkedList<int>();
            linkedList3.Append(0);
            linkedList3.Append(1);
            linkedList3.Append(2);
            linkedList3.Append(3);
            Console.WriteLine(linkedList3);
            
            linkedList3.RemoveAt(0);
            Console.WriteLine(linkedList3);
            linkedList3.RemoveAt(1);
            Console.WriteLine(linkedList3);
            linkedList3.RemoveAt(1);
            Console.WriteLine(linkedList3);
            linkedList3.RemoveAt(0);
            Console.WriteLine(linkedList3);
        }
    }
}
